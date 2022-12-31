using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.UserFile.Models.Responses;
using Jorda.Client.Common.Services.UserFile.Models.Requests;

namespace Jorda.Client.Services.UserFile;

public interface IUserFileService
{
    Task Delete(Guid id, Guid goalId);
    Task<Guid> Create(CreateUserFileRequest request);
    Task<UserFileDetailsReponse> GetById(Guid id, Guid goalId);
    Task<PagedResult<UserFileResponse>> GetAll();
}
