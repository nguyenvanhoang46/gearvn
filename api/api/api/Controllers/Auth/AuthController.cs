using System.Net;
using System.Security.Claims;
using api.Context;
using api.Libs;
using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using api.Models.Dtos.Response;
using api.Services.IServices;
using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Auth;

[ApiController]
[Route("/api/[controller]")]
public class AuthController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  private readonly IConfiguration _configuration;
  private readonly IJwtService _jwtService;

  public AuthController(IUnitOfWork unitOfWork,
    IMapper mapper,
    IMetaService metaService,
    IConfiguration configuration,
    IJwtService jwtService)
  {
    _unitOfWork = unitOfWork;
    _mapper = mapper;
    _configuration = configuration;
    _jwtService = jwtService;
  }

  [HttpPost(Routes.API_AUTH_LOGIN)]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
  {
    var result = await _unitOfWork.UserRepository.LoginAsync(loginDto);

    if (result == null)
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), HttpStatusCode.BadRequest);

    return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), result);
  }

  [HttpPost(Routes.API_AUTH_REGISTER)]
  [IgnoreAntiforgeryToken]
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

  [HttpGet(Routes.API_AUTH_ME)]
  [IgnoreAntiforgeryToken]
  [Authorize]
  public async Task<IActionResult> GetMe()
  {
    ClaimsPrincipal currentUser = User;
    var user = await _unitOfWork.UserRepository.GetMe(currentUser);
    if (user == null)
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);
    UserDto userDto = _mapper.Map<User, UserDto>(user);
    return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), userDto);
  }

  [HttpPost(Routes.API_AUTH_REFRESH_TOKEN)]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenDto refreshTokenDto)
  {
    try
    {
      var principal = _jwtService.GetPrincipalFromExpiredToken(refreshTokenDto.Token);
      if (principal == null)
      {
        return CustomResult("Invalid access token", HttpStatusCode.BadRequest);
      }

      var user = await _unitOfWork.UserRepository.FindByEmail(principal.FindFirstValue(ClaimTypes.Email));

      if (user == null || user.RefreshToken != refreshTokenDto.RefreshToken ||
          user.RefreshTokenExpiryTime < DateTime.Now)
      {
        return CustomResult("Invalid access token or refresh token", HttpStatusCode.BadRequest);
      }

      var roles = await _unitOfWork.UserRepository.GetRoleByUser(user);
      var newAccessToken = _jwtService.GenerateToken(user, roles);
      var newRefreshToken = _jwtService.GenerateRefreshToken();
      _ = int.TryParse(_configuration["JWT:TokenExpiresMinutes"], out int tokenExpiresTime);

      user.RefreshToken = newRefreshToken;
      await _unitOfWork.UserRepository.UpdateAsync(user);
      return CustomResult(new TokenDto()
      {
        AccessToken = newAccessToken,
        RefreshToken = newRefreshToken,
        TokenExpires = DateTime.Now.AddMinutes(tokenExpiresTime),
      });
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), e.Message,
        HttpStatusCode.BadRequest);
    }
  }
}
