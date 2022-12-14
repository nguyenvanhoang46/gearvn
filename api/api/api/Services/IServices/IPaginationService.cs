using api.Filters;
using api.Models.Dtos;

namespace api.Services.IServices;

public interface IPaginationService
{
  public PaginateDto<List<T>>
    CreatePagedResponse<T>(List<T> pagedData, PaginationFilter validFilter, int totalRecords, IMetaService uriService,
      string route);
}
