using System.Net;
using api.Context;
using api.Libs;
using api.Models;
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

  [HttpPost("CreateOrder")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto createOrderDto)
  {
    try
    {
      User customer = await _unitOfWork.UserRepository.FindById(createOrderDto.UserId);
      if (customer == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), HttpStatusCode.BadRequest);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError),
        e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPost("UpdateOrder")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> UpdateOrder([FromBody] UpdateOrderDto updateOrderDto)
  {
    try
    {
      return BadRequest();
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), e.Message,
        HttpStatusCode.BadRequest);
    }
  }
}
