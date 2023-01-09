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
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Admin;

[ApiController]
[Route("api/Admin/[controller]")]
[Authorize(Roles = "Admin")]
public class ProductController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IMapper _mapper;
  private readonly IMetaService _metaService;
  private readonly IUploadFile _uploadFile;

  public ProductController(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    IMetaService metaService,
    IUploadFile uploadFile
  )
  {
    _unitOfWork = unitOfWork;
    _mapper = mapper;
    _metaService = metaService;
    _uploadFile = uploadFile;
  }

  [HttpGet(Routes.API_ADMIN_PRODUCT_GET_PRODUCTS)]
  public async Task<IActionResult> GetProducts([FromQuery] PaginationFilter paginationFilter,
    [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
  {
    try
    {
      PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
      List<Product> products = _unitOfWork.ProductRepository.Paginate(out var total,
        paginationFilter: pagination,
        orderByQueryString: sortingFilter.OrderBy,
        relations: "Category",
        predicate: x =>
          x.Name.Contains(searchFilter.Search ?? "") || x.Description.Contains(searchFilter.Search ?? "")).ToList();

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

  [HttpGet(Routes.API_ADMIN_GET_PRODUCT_BY_ID)]
  public async Task<IActionResult> GetProductById([FromRoute] string Id)
  {
    try
    {
      Product? product = await _unitOfWork.ProductRepository.FindById(Id);

      if (product == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK),
        _mapper.Map<Product, ProductDto>(product));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPost(Routes.API_ADMIN_PRODUCT_CREATE_PRODUCT)]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto productDto)
  {
    try
    {
      Product product = new Product
      {
        Name = productDto.Name,
        Description = productDto.Description,
        Price = productDto.Price,
        Category = productDto.CategoryId != String.Empty
          ? await _unitOfWork.CategoryRepository.FindById(productDto.CategoryId!)
          : null,
        SalePrice = productDto.SalePrice ?? 0,
        Content = productDto.Content,
      };

      await _unitOfWork.ProductRepository.Add(product);
      await _unitOfWork.SaveAsync();
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.Created), HttpStatusCode.Created);
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpPut(Routes.API_ADMIN_UPDATE_PRODUCT)]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductDto productDto, [FromRoute] string id)
  {
    try
    {
      Product? product = await _unitOfWork.ProductRepository.FindById(id);

      if (product == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      _unitOfWork.ProductRepository.Update(_mapper.Map<UpdateProductDto, Product>(productDto));

      await _unitOfWork.SaveAsync();

      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK));
    }
    catch (Exception e)
    {
      return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
        HttpStatusCode.InternalServerError);
    }
  }

  [HttpDelete(Routes.API_ADMIN_DELETE_PRODUCT)]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> DeleteProduct([FromRoute] string id)
  {
    try
    {
      Product? product = await _unitOfWork.ProductRepository.FindById(id);

      if (product == null)
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

      _unitOfWork.ProductRepository.SoftDelete(product);

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
