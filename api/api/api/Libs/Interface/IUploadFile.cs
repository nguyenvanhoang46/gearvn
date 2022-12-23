using api.Models.Dtos;

namespace api.Libs.Interface;

public interface IUploadFile
{
  public Task<List<ImageDto>> Store(List<IFormFile> files, string dist);
}
