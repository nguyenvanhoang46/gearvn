using System.Dynamic;
using System.Net;
using api.Context;
using api.Filters;
using api.Libs;
using api.Libs.Interface;
using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using api.Services;
using api.Services.IServices;
using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Admin;

[ApiController]
[Route("api/Admin/[controller]")]
[Authorize(Roles = "Admin")]
public class UserController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMetaService _metaService;
  private readonly IUploadFile _uploadFile;
  private readonly IMapper _mapper;

  public UserController(
    IUnitOfWork unitOfWork,
    IMetaService metaService,
    IUploadFile uploadFile,
    IMapper mapper
  )
  {
    _unitOfWork = unitOfWork;
    _metaService = metaService;
    _uploadFile = uploadFile;
    _mapper = mapper;
  }


  [HttpGet("User")]
  public async Task<IActionResult> GetUsers([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
  {
    try
    {
      PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
      List<User> users = _unitOfWork.UserRepository.Paginate(out var total,
        paginationFilter: pagination,
        orderByQueryString: sortingFilter.OrderBy,
        predicate: x =>
          x.FirstName.Contains(searchFilter.Search ?? "") || x.LastName.Contains(searchFilter.Search ?? "")).ToList();

      if (users.ToList().Count <= 0)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), users.ToList(),
          HttpStatusCode.NotFound);

      List<UserDto> usersDto = _mapper.Map<List<User>, List<UserDto>>(users.ToList());

      var list = new List<object>();

      list = usersDto.ToList()
        .ConvertAll<object>(user =>
        {
          List<string>? roles = _unitOfWork.UserRepository.GetRoleByUser(_mapper.Map<User>(user)).Result;

          if (roles?.Count < 0)
            roles[0] = "";

          return new
          {
            id = user.Id,
            firstName = user.FirstName,
            lastName = user.LastName,
            fullName = user.FullName,
            email = user.Email,
            phoneNumber = user.Phone,
            roles,
          };
        });

      string route = Request.Path.Value ?? throw new ArgumentNullException("Request.Path.Value");

      var response = PaginationService.CreatePagedResponse(list, pagination,
        total, _metaService, route!);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), response);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpGet("User/{id}")]
  public async Task<IActionResult> GetUserById([FromRoute] string id)
  {
    try
    {
      User? user = await _unitOfWork.UserRepository.FindById(id);

      if (user == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { },
          HttpStatusCode.NotFound);

      UserDto userDto = _mapper.Map<User, UserDto>(user);

      List<string>? roles = _unitOfWork.UserRepository.GetRoleByUser(user).Result;

      if (roles?.Count < 0)
        roles[0] = "";

      var response = new
      {
        id = userDto.Id,
        firstName = userDto.FirstName,
        lastName = userDto.LastName,
        fullName = userDto.FullName,
        email = userDto.Email,
        phoneNumber = userDto.Phone,
        roles,
      };

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), response);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPost("CreateUser")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> CreateUser([FromBody] CreateUserDto createUserDto)
  {
    try
    {
      bool result = await _unitOfWork.UserRepository.CreateUser(createUserDto);

      if (!result)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), "Create user failed",
          HttpStatusCode.BadRequest);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPut("UpdateUser/{id}")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto updateUserDto, [FromRoute] string id)
  {
    try
    {
      User user = await _unitOfWork.UserRepository.GetCurrentUser(HttpContext);

      bool result = await _unitOfWork.UserRepository.UpdateUser(updateUserDto, id, user);

      if (!result)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), "Update User Failed",
          HttpStatusCode.BadRequest);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }


  [HttpDelete("DeleteUser/{id}")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> DeleteUser([FromRoute] string id)
  {
    try
    {
      bool result = await _unitOfWork.UserRepository.DeleteUser(id);

      if (!result)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), "Delete User Failed",
          HttpStatusCode.BadRequest);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }
}
