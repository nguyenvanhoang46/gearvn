using System.Net;
using api.Context;
using api.Libs;
using api.Libs.Interface;
using api.Models;
using api.Models.Dtos;
using api.Models.Dtos.Request;
using api.Models.Morph;
using AutoMapper;
using CoreApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Admin;

[ApiController]
[Route("api/Admin/[controller]")]
public class ImageController : BaseController
{
  private readonly IUnitOfWork _unitOfWork;
  private readonly IUploadFile _uploadFile;
  private readonly IMapper _mapper;

  public ImageController(
    IUnitOfWork unitOfWork,
    IUploadFile uploadFile,
    IMapper mapper
  )
  {
    _unitOfWork = unitOfWork;
    _uploadFile = uploadFile;
    _mapper = mapper;
  }

  [HttpPost("UploadImage")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> UploadImage([FromForm] UploadImageDto uploadImageDto)
  {
    switch (uploadImageDto.ImageFor)
    {
      case ImageFor.Product:
        try
        {
          Product? product = await _unitOfWork.ProductRepository.FindById(uploadImageDto.Id);
          if (product == null)
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

          List<ImageDto> productImage = await _uploadFile.Store(uploadImageDto.Image, "resources");

          product.Images = _mapper.Map<List<ImageDto>, List<Image>>(productImage);

          _unitOfWork.ProductRepository.Update(product);

           _unitOfWork.Save();

          return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), _mapper);
        }
        catch (Exception e)
        {
          return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), e.Message,
            HttpStatusCode.BadRequest);
        }
      case ImageFor.Category:
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);
      case ImageFor.User:
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);
      default:
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), HttpStatusCode.BadRequest);
    }
  }

  [HttpPost("DeleteImage")]
  [IgnoreAntiforgeryToken]
  public async Task<IActionResult> DeleteImage([FromForm] DeleteImageDto deleteImageDto)
  {
    switch (deleteImageDto.ImageFor)
    {
      case ImageFor.Product:
        try
        {
          Product? product = await _unitOfWork.ProductRepository.FindById(deleteImageDto.Id);
          if (product == null)
            return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);

          deleteImageDto.ImageIds.ForEach(async imageId =>
          {
            Image? image = product.Images.FirstOrDefault(i => i.Id == imageId);
            if (image != null)
            {
              product.Images.Remove(image);
              await _unitOfWork.SaveAsync();
            }
          });

          return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.OK), _mapper);
        }
        catch (Exception e)
        {
          return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), e.Message,
            HttpStatusCode.BadRequest);
        }
      case ImageFor.Category:
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);
      case ImageFor.User:
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.NotFound), HttpStatusCode.NotFound);
      default:
        return CustomResult(ResponseType.GetMessageFormCode(HttpStatusCode.BadRequest), HttpStatusCode.BadRequest);
    }
  }
}
