using api.Context;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Admin;

[ApiController]
[Route("api/[controller]")]
public class OrderController
{
  private readonly IMapper _mapper;
  private readonly IUnitOfWork _unitOfWork;

  public OrderController(
    IMapper mapper,
    IUnitOfWork unitOfWork
  )
  {
    _mapper = mapper;
    _unitOfWork = unitOfWork;
  }
}
