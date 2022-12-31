using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.UserFile.Models.Requests;
using Jorda.Client.Common.Services.UserFile.Models.Responses;

namespace Jorda.Client.Services.UserFile;

public class UserFileService : IUserFileService
{
    public Task<Guid> Create(CreateUserFileRequest request)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id, Guid goalId)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<UserFileResponse>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<UserFileDetailsReponse> GetById(Guid id, Guid goalId)
    {
        throw new NotImplementedException();
    }
}
