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
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Home;

[ApiController]
[Route("/api/[controller]")]
public class ProductController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  private readonly IMetaService _metaService;

  public ProductController(IUnitOfWork unitOfWork, IMapper mapper, IMetaService metaService)
  {
    _unitOfWork = unitOfWork;
    _mapper = mapper;
    _metaService = metaService;
  }

  [HttpGet("GetProducts")]
  public async Task<IActionResult> GetProducts([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
  {
    try
    {
      PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
      IEnumerable<Product> products = _unitOfWork.ProductRepository.Paginate(out var total,
        paginationFilter: pagination,
        orderByQueryString: sortingFilter.OrderBy,
        predicate: x =>
          x.Name.Contains(searchFilter.Search ?? "") || x.Description.Contains(searchFilter.Search ?? ""));

      if (products.ToList().Count <= 0)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      List<ProductDto> productDto = _mapper.Map<List<Product>, List<ProductDto>>(products.ToList());

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

  [HttpGet("GetProductsByCategory")]
  public async Task<IActionResult> GetProductsByCategory([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] GetProductByCategoryDto getProductByCategoryDto)
  {
    try
    {
      PaginationFilter pagination =
        new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
      IEnumerable<Product> products = _unitOfWork.ProductRepository.Paginate(out var total,
        paginationFilter: pagination,
        orderByQueryString: sortingFilter.OrderBy,
        relations: "Category",
        predicate: x => x.Category!.Id == getProductByCategoryDto.CategoryId);

      if (products.ToList().Count <= 0)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      List<ProductDto> productDto = _mapper.Map<List<Product>, List<ProductDto>>(products.ToList());

      string route = Request.Path.Value ?? throw new ArgumentNullException("Request.Path.Value");

      var response = PaginationService.CreatePagedResponse(productDto, pagination,
        total, _metaService, route!);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), response, HttpStatusCode.OK);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpGet("GetProductById/{id}")]
  public async Task<IActionResult> GetProductDetails([FromRoute] string id)
  {
    try
    {
      Product? product = await _unitOfWork.ProductRepository.FindById(id);
      if (product == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      ProductDto productDto = _mapper.Map<Product, ProductDto>(product);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), productDto, HttpStatusCode.OK);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }
}
