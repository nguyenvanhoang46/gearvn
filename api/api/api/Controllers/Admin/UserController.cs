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
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Admin;

[ApiController]
[Route("api/Admin/[controller]")]
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

      List<UserDto> productDto = _mapper.Map<List<User>, List<UserDto>>(users.ToList());

      string route = Request.Path.Value ?? throw new ArgumentNullException("Request.Path.Value");

      var response = PaginationService.CreatePagedResponse(productDto, pagination,
        total, _metaService, route!);

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
  public async Task<IActionResult> UpdateUser([FromBody] UpdateUserDto updateUserDto, [FromRoute] string id)
  {
    try
    {
      bool result = await _unitOfWork.UserRepository.UpdateUser(updateUserDto, id);

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
