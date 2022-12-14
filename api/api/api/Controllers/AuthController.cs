using System.Net;
using System.Security.Claims;
using api.Context;
using api.Libs;
using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using api.Services;
using api.Services.IServices;
using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Home;

[ApiController]
[Route("/api/[controller]")]
public class AuthController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  private readonly IJwtService _jwtService;

  public AuthController(IUnitOfWork unitOfWork,
    IMapper mapper,
    IMetaService metaService,
    IJwtService jwtService)
  {
    _unitOfWork = unitOfWork;
    _mapper = mapper;
    _jwtService = jwtService;
  }

  [HttpPost("Login")]
  public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
  {
    var result = await _unitOfWork.UserRepository.LoginAsync(loginDto);

    if (result == null)
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), HttpStatusCode.BadRequest);

    return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), result);
  }

  [HttpPost("Register")]
  public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
  {
    var result = await _unitOfWork.UserRepository.RegisterAsync(registerDto);
    if (result.Succeeded)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.Created));
    }

    List<string> errors = new List<string>();
    foreach (var error in result.Errors)
    {
      errors.Add(error.Description);
    }

    return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), errors, HttpStatusCode.BadRequest);
  }

  [HttpGet("Me")]
  [Authorize]
  public async Task<IActionResult> GetMe()
  {
    ClaimsPrincipal currentUser = this.User;
    var user = await _unitOfWork.UserRepository.GetMe(currentUser);
    if (user == null)
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);
    UserDto userDto = _mapper.Map<User, UserDto>(user);
    return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), userDto);
  }
}
