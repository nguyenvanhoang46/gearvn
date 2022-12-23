using System.Net;
using api.Context;
using api.Filters;
using api.Libs;
using api.Libs.Interface;
using api.Models.Dtos.Request;
using api.Services.IServices;
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

  public UserController(
    IUnitOfWork unitOfWork,
    IMetaService metaService,
    IUploadFile uploadFile
  )
  {
    _unitOfWork = unitOfWork;
    _metaService = metaService;
    _uploadFile = uploadFile;
  }


  [HttpGet("User")]
  public async Task<IActionResult> GetUsers([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
  {
    try
    {
      return Ok();
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPost("CreateUser")]
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
