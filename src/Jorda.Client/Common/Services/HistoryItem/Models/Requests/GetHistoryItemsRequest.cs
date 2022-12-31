using Jorda.Client.Common.Enums;

namespace Jorda.Client.Common.Services.HistoryItem.Models.Requests
{
    public class GetHistoryItemsRequest
    {
        public string UserId { get; set; } = null!;

        public string? SearchPhrase { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string? SortBy { get; set; }

        public SortDirection SortDirection { get; set; }
    }
}
