using Jorda.Client.Common.Extensions;
using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.HistoryItem.Models.Requests;
using Jorda.Client.Common.Services.HistoryItem.Models.Responses;
using Microsoft.AspNetCore.WebUtilities;

namespace Jorda.Client.Services.HistoryItem;

public class HistoryItemService : IHistoryItemService
{
    private IHttpService _httpService;

    public HistoryItemService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<PagedResult<HistoryItemResponse>> GetAll(GetHistoryItemsRequest request)
    {
        return await _httpService.Get<PagedResult<HistoryItemResponse>>(QueryHelpers.AddQueryString("/historyItem", request.ToDictionary()));
    }
}
