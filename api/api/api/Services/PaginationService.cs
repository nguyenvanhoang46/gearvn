                                                                                                                                                             using api.Filters;
                                                                                                                                                             using api.Models.Dtos;
                                                                                                                                                             using api.Services.IServices;

                                                                                                                                                             namespace api.Services;

public class PaginationService
{
  public static PaginateDto<List<T>> CreatePagedResponse<T>(List<T> pagedData, PaginationFilter validFilter,
    int totalRecords, IMetaService metaService, string route)
  {
    var response = new PaginateDto<List<T>>(pagedData, validFilter.PageNumber, validFilter.PageSize);
    var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
    int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));
    response.NextPage =
      validFilter.PageNumber >= 1 && validFilter.PageNumber < roundedTotalPages
        ? metaService.GetPageMeta(new PaginationFilter(validFilter.PageNumber + 1, validFilter.PageSize), route)
        : null;
    response.PreviousPage =
      validFilter.PageNumber - 1 >= 1 && validFilter.PageNumber <= roundedTotalPages
        ? metaService.GetPageMeta(new PaginationFilter(validFilter.PageNumber - 1, validFilter.PageSize), route)
        : null;
    response.FirstPage = metaService.GetPageMeta(new PaginationFilter(1, validFilter.PageSize), route);
    response.LastPage = metaService.GetPageMeta(new PaginationFilter(roundedTotalPages, validFilter.PageSize), route);
    response.TotalPages = roundedTotalPages;
    response.TotalRecords = totalRecords;
    return response;
  }
}
