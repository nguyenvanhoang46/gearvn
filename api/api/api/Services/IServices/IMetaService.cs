using api.Filters;

namespace api.Services.IServices;

public interface IMetaService
{
  public Uri GetPageMeta(PaginationFilter filter, string route);
}
