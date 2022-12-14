namespace api.Models.Dtos;

public class PaginateDto<T>
{
  public int PageNumber { get; set; }

  public int PageSize { get; set; }

  public Uri? FirstPage { get; set; }

  public Uri? LastPage { get; set; }

  public int TotalPages { get; set; }

  public T Data { get; set; }

  public int TotalRecords { get; set; }

  public Uri? NextPage { get; set; }

  public Uri? PreviousPage { get; set; }

  public PaginateDto(T data, int pageNumber, int pageSize)
  {
    this.PageNumber = pageNumber;
    this.PageSize = pageSize;
    this.Data = data;
  }
}
