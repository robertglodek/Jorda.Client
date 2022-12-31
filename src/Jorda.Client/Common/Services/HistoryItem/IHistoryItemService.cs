using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.HistoryItem.Models.Requests;
using Jorda.Client.Common.Services.HistoryItem.Models.Responses;

namespace Jorda.Client.Services.HistoryItem;

public interface IHistoryItemService
{
    Task<PagedResult<HistoryItemResponse>> GetAll(GetHistoryItemsRequest request);
}
