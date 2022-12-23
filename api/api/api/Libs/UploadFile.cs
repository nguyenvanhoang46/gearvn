using api.Libs.Interface;
using api.Models.Dtos;
using MimeTypes;

namespace api.Libs;

public class UploadFile : IUploadFile
{
  private readonly IWebHostEnvironment _environment;
  private readonly IConfiguration _configuration;

  public UploadFile(IWebHostEnvironment environment, IConfiguration configuration)
  {
    _environment = environment;
    _configuration = configuration;
  }

  public async Task<List<ImageDto>> Store(List<IFormFile> files, string dist = "source")
  {
    var directoryPath = Path.Combine(_environment.WebRootPath, "resources");

    if (!Directory.Exists(directoryPath))
    {
      Directory.CreateDirectory(directoryPath);
    }

    var urlApp = $"{_configuration["App:BaseUrl"]}/{dist}";

    var listUrl = new List<ImageDto>();

    foreach (var file in files)
    {
      var extension = file.FileName.Split(".")[1];
      var fileName = $"{Guid.NewGuid().ToString()}.{extension}";

      var filePath = Path.Combine(directoryPath, fileName);
      var fileUrl = $"{urlApp}/{fileName}";
      listUrl.Add(new ImageDto()
      {
        Url = fileUrl,
        MineType = MimeTypeMap.GetMimeType(extension),
        Alt = fileName
      });

      await using var stream = new FileStream(filePath, FileMode.Create);
      await file.CopyToAsync(stream);
    }

    return listUrl;
  }
}
