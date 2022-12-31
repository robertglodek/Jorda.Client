using Jorda.Client.Common.Services.Note.Models.Requests;
using Jorda.Client.Common.Services.Note.Models.Responses;
using Jorda.Client.Common.Services;
using Microsoft.AspNetCore.WebUtilities;
using Jorda.Client.Common.Services.ToDoItem.Models.Requests;
using Jorda.Client.Common.Services.ToDoItem.Models.Responses;
using Jorda.Client.Common.Extensions;

namespace Jorda.Client.Services.ToDoItem;

public class ToDoItemService:IToDoItemService
{
    private IHttpService _httpService;

    public ToDoItemService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<Guid> Create(CreateToDoItemRequest request)
    {
        return await _httpService.Post<Guid>($"/section/{request.SectionId}/toDoItem", request);
    }

    public async Task Delete(Guid id, Guid sectionId)
    {
        await _httpService.Delete($"/section/{sectionId}/toDoItem/{id}");
    }

    public async Task<PagedResult<ToDoItemResponse>> GetAll(GetToDoItemsRequest request)
    {
        return await _httpService.Get<PagedResult<ToDoItemResponse>>(QueryHelpers.AddQueryString($"/section/{request.SectionId}/toDoItem", request.ToDictionary()));
    }

    public async Task<ToDoItemResponse> GetById(Guid id, Guid sectionId)
    {
        return await _httpService.Get<ToDoItemResponse>($"/section/{sectionId}/toDoItem/{id}");
    }

    public async Task Update(UpdateToDoItemRequest request)
    {
        await _httpService.Put($"/section/{request.SectionId}/toDoItem/{request.Id}", request);
    }
}
