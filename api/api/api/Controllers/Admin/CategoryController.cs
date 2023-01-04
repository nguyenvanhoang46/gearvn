using System.Net;
using api.Context;
using api.Filters;
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

namespace api.Controllers.Admin;

[ApiController]
[Route("api/Admin/[controller]")]
public class CategoryController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  private readonly IMetaService _metaService;

  public CategoryController(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    IMetaService metaService
  )
  {
    _unitOfWork = unitOfWork;
    _mapper = mapper;
    _metaService = metaService;
  }

  [HttpGet(Routes.API_ADMIN_CATEGORY_GET_CATEGORIES)]
  [Authorize(Roles = "Admin")]
  public async Task<IActionResult> GetCategories([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
  {
    try
    {
      PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
      List<Category> categories = _unitOfWork.CategoryRepository.Paginate(out var total,
        paginationFilter: pagination,
        orderByQueryString: sortingFilter.OrderBy,
        predicate: x =>
          x.Name.Contains(searchFilter.Search ?? "") || x.Name.Contains(searchFilter.Search ?? "")).ToList();

      if (categories.ToList().Count <= 0)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), categories.ToList(),
          HttpStatusCode.NotFound);

      List<CategoryDto> categoryDto = _mapper.Map<List<Category>, List<CategoryDto>>(categories.ToList());

      string route = Request.Path.Value ?? throw new ArgumentNullException("Request.Path.Value");

      var response = PaginationService.CreatePagedResponse(categoryDto, pagination,
        total, _metaService, route!);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), response);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpGet(Routes.API_ADMIN_GET_CATEGORY_BY_ID)]
  [Authorize(Roles = "Admin")]
  public async Task<IActionResult> GetCategoryById([FromRoute] string Id)
  {
    try
    {
      Category? category = await _unitOfWork.CategoryRepository.FindById(Id);

      if (category == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), category,
          HttpStatusCode.NotFound);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK),
        _mapper.Map<Category, CategoryDto>(category));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPost(Routes.API_ADMIN_CATEGORY_CREATE_CATEGORY)]
  [IgnoreAntiforgeryToken]
  [Authorize(Roles = "Admin")]
  public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto categoryDto)
  {
    try
    {
      Category category = new Category
      {
        Name = categoryDto.Name
      };

      await _unitOfWork.CategoryRepository.Add(category);
      await _unitOfWork.SaveAsync();
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.Created), HttpStatusCode.Created);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPut(Routes.API_ADMIN_UPDATE_CATEGORY)]
  [IgnoreAntiforgeryToken]
  [Authorize(Roles = "Admin")]
  public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto categoryDto, [FromRoute] string id)
  {
    try
    {
      Category? category = await _unitOfWork.CategoryRepository.FindById(id);

      if (category == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound),
          HttpStatusCode.NotFound);

      _unitOfWork.CategoryRepository.Update(_mapper.Map<UpdateCategoryDto, Category>(categoryDto));

      await _unitOfWork.SaveAsync();

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpDelete(Routes.API_ADMIN_DELETE_CATEGORY)]
  [IgnoreAntiforgeryToken]
  [Authorize(Roles = "Admin")]
  public async Task<IActionResult> DeleteCategory([FromRoute] string id)
  {
    try
    {
      Category? category = await _unitOfWork.CategoryRepository.FindById(id);

      if (category == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      _unitOfWork.CategoryRepository.SoftDelete(category);

      await _unitOfWork.SaveAsync();

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }
}
