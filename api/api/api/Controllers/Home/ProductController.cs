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

    [HttpGet(Routes.API_PRODUCT_GET_PRODUCTS)]
    public async Task<IActionResult> GetProducts([FromQuery] PaginationFilter paginationFilter,
      [FromQuery] SortingFilter sortingFilter, [FromQuery] SearchFilter searchFilter)
    {
        try
        {
            PaginationFilter pagination = new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
            List<Product> products = _unitOfWork.ProductRepository.Paginate(out var total,
              paginationFilter: pagination,
              orderByQueryString: sortingFilter.OrderBy,
              relations: "Category,Images",
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

    [ValidateStatusCodes]
    [HttpGet(Routes.API_PRODUCT_GET_PRODUCTS_BY_CATEGORY)]
    public async Task<IActionResult> GetProductsByCategory([FromQuery] PaginationFilter paginationFilter,
      [FromQuery] SortingFilter sortingFilter, [FromRoute] string categoryId)
    {
        try
        {
            PaginationFilter pagination =
              new PaginationFilter(paginationFilter.PageNumber, paginationFilter.PageSize);
            IEnumerable<Product> products = _unitOfWork.ProductRepository.Paginate(out var total,
              paginationFilter: pagination,
              orderByQueryString: sortingFilter.OrderBy,
              relations: "Category",
              predicate: x => x.Category!.Id == categoryId);

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

    [ValidateStatusCodes]
    [HttpGet(Routes.API_PRODUCT_GET_PRODUCT_BY_ID)]
    public async Task<IActionResult> GetProductDetails([FromRoute] string id)
    {
        try
        {
            Product? product = await _unitOfWork.ProductRepository.FindById(id, "Images");
            if (product == null)
                return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

            ProductDto productDto = _mapper.Map<Product, ProductDto>(product);

            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), productDto);
        }
        catch (Exception e)
        {
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.InternalServerError), e.Message,
              HttpStatusCode.InternalServerError);
        }
    }
}
