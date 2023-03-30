using System.Net;
using api.Context;
using api.Filters;
using api.Libs;
using api.Models;
using api.Models.Dtos;
using api.Services;
using api.Services.IServices;
using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Admin;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin")]
public class OrderController : BaseController
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMetaService _metaService;

    public OrderController(
        IMapper mapper,
        IUnitOfWork unitOfWork,
        IMetaService metaService
    )
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
        _metaService = metaService;
    }


    [HttpGet(Routes.API_ADMIN_ORDER_GET_ORDERS)]
    public async Task<IActionResult> GetOrders([FromQuery] PaginationFilter paginationFilter,
        [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
    {
        try
        {
            PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
            List<Order> orders = _unitOfWork.OrderRepository.Paginate(out var total,
                paginationFilter: pagination,
                relations: "User,OrderDetails.Product",
                orderByQueryString: sortingFilter.OrderBy).ToList();

            List<OrderDto> orderDto = _mapper.Map<List<Order>, List<OrderDto>>(orders.ToList());

            string route = Request.Path.Value ?? throw new ArgumentNullException("Request.Path.Value");

            var response = PaginationService.CreatePagedResponse(orderDto, pagination,
                total, _metaService, route!);

            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), response);
        }
        catch (Exception e)
        {
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
                HttpStatusCode.InternalServerError);
        }
    }
}