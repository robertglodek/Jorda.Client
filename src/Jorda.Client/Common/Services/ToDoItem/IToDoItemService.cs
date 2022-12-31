using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.ToDoItem.Models.Requests;
using Jorda.Client.Common.Services.ToDoItem.Models.Responses;

namespace Jorda.Client.Services.ToDoItem;

public interface IToDoItemService
{
    Task Delete(Guid id, Guid sectionId);
    Task<Guid> Create(CreateToDoItemRequest request);
    Task Update(UpdateToDoItemRequest request);
    Task<ToDoItemResponse> GetById(Guid id, Guid sectionId);
    Task<PagedResult<ToDoItemResponse>> GetAll(GetToDoItemsRequest request);
}
