using Jorda.Client.Common.Enums;

namespace Jorda.Client.Common.Services.ToDoItem.Models.Requests;

public class GetToDoItemsRequest
{
    public Guid SectionId { get; set; }
    public string? SearchPhrase { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public string? SortBy { get; set; }
    public SortDirection SortDirection { get; set; }
}


