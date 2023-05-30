using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Application.Models;

public class GetAllMoviesOptions
{
    public string? Title { get; set; }
    public int? YearOfRelease { get; set; }
    public Guid? UserId { get; set; }
    public string? SortField { get; set; }
    public SortOrder? SortOrder { get; set; }
    public int Page { get; init; }
    public int PageSize { get; init; }
}

public enum SortOrder
{
    Unsorted,
    Ascending,
    Descending
}
