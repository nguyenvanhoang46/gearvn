using api.Filters;
using api.Services.IServices;
using Microsoft.AspNetCore.WebUtilities;

namespace api.Services;

public class MetaService : IMetaService
{
  private readonly string _baseUri;

  public MetaService(string baseUri)
  {
    _baseUri = baseUri;
  }

  public Uri GetPageMeta(PaginationFilter filter, string route)
  {
    var endpoint = new Uri(string.Concat(_baseUri, route));
    var modifiedUri = QueryHelpers.AddQueryString(endpoint.ToString(), "pageNumber", filter.PageNumber.ToString());
    modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pageSize", filter.PageSize.ToString());
    return new Uri(modifiedUri);
  }
}
