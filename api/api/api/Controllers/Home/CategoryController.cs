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
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Home;

[ApiController]
[Route("/api/[controller]")]
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

  [HttpGet(Routes.API_CATEGORIES_GET_CATEGORIES)]
  public async Task<IActionResult> GetCategories([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
  {
    try
    {
      PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
      IEnumerable<Category> categories = _unitOfWork.CategoryRepository.Paginate(out var total,
        paginationFilter: pagination,
        orderByQueryString: sortingFilter.OrderBy,
        predicate: x =>
          x.Name.Contains(searchFilter.Search ?? ""));

      if (categories.ToList().Count <= 0)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), new { },
          HttpStatusCode.NotFound);

      List<CategoryDto> productDto = _mapper.Map<List<Category>, List<CategoryDto>>(categories.ToList());

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
}
