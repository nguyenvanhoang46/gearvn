using System.Net;
using System.Runtime.CompilerServices;
using api.Context;
using api.Libs;
using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Home;

[ApiController]
[Route("/api/[controller]")]
public class OrderController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public OrderController(
      IUnitOfWork unitOfWork,
      IMapper mapper
    )
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet("GetAllOrderByUserId/{id}")]
    public async Task<IActionResult> GetAllOrderByUserId([FromRoute] string id)
    {
        try
        {
            User? user = await _unitOfWork.UserRepository.FindById(id);
            if (user == null)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { }, HttpStatusCode.NotFound);

            List<Order> orders = await _unitOfWork.OrderRepository.GetAllOrderByUserId(id);
            if (orders.Count == 0)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { },
                  HttpStatusCode.NotFound);

            List<OrderDto> orderDtos = _mapper.Map<List<OrderDto>>(orders);

            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), orderDtos, HttpStatusCode.OK);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    [HttpGet("GetOrder/{id}")]
    public async Task<IActionResult> GetOrderById([FromRoute] string id)
    {
        try
        {
            Order? order = await _unitOfWork.OrderRepository.FindById(id);

            if (order == null)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { }, HttpStatusCode.NotFound);

            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), _mapper.Map<Order, OrderDto>(order),
              HttpStatusCode.OK);
        }
        catch (Exception e)
        {
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError),
              e.Message,
              HttpStatusCode.InternalServerError);
        }
    }

    [HttpPost("CreateOrder")]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto createOrderDto)
    {
        try
        {
            User? customer = await _unitOfWork.UserRepository.FindById(createOrderDto.UserId);

            if (customer == null)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { }, HttpStatusCode.NotFound);

            var orderDetail = new List<OrderDetail>();

            if (createOrderDto.OrderItems.Count <= 0)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { }, HttpStatusCode.NotFound);


            foreach (var item in createOrderDto.OrderItems)
            {
                Product? product = await _unitOfWork.ProductRepository.FindById(item.ProductId);

                if (product != null)
                {
                    orderDetail.Add(new OrderDetail()
                    {
                        Product = product,
                        Quantity = item.Quantity,
                    });
                }
            }

            Order order = new Order
            {
                User = customer,
                OrderType = OrderType.Pending,
                OrderCompletionType = OrderCompletedType.Inventory,
                OrderDetails = orderDetail,
                Address = createOrderDto.Address,
                City = createOrderDto.City,
            };

            await _unitOfWork.OrderRepository.Add(order);
            await _unitOfWork.SaveAsync();

            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
        }
        catch (Exception e)
        {
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError),
              e.Message,
              HttpStatusCode.InternalServerError);
        }
    }

    [HttpPut("UpdateOrder")]
    [IgnoreAntiforgeryToken]
    public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderDto updateOrderDto)
    {
        try
        {
            Order? order = await _unitOfWork.OrderRepository.FindById(updateOrderDto.OrderId);
            if (order == null)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { }, HttpStatusCode.NotFound);

            order.OrderType = updateOrderDto.OrderType;
            order.OrderCompletionType = updateOrderDto.OrderCompletionType;
            order.Address = updateOrderDto.Address;

            List<OrderDetail> orderDetail = updateOrderDto.OrderItems.ToList().ConvertAll<OrderDetail>(person =>
            {
                Product? product = _unitOfWork.ProductRepository.FindById(person.ProductId).Result;
                if (product == null)
                    return null;
                return new OrderDetail
                {
                    Product = product,
                    Quantity = person.Quantity,
                };
            });

            order.OrderDetails = orderDetail;

            _unitOfWork.OrderRepository.Update(order);

            await _unitOfWork.SaveAsync();

            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
        }
        catch (Exception e)
        {
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), e.Message,
              HttpStatusCode.BadRequest);
        }
    }
}
