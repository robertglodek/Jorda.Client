using Jorda.Client.Common.Services.Section.Models.Requests;
using Jorda.Client.Common.Services.Section.Models.Responses;

namespace Jorda.Client.Services.Section;

public interface ISectionService
{
    Task Delete(Guid id, Guid goalId);
    Task<Guid> Create(CreateSectionRequest request);
    Task Update(UpdateSectionRequest request);
    Task<SectionResponse> GetById(Guid id, Guid goalId);
    Task<IEnumerable<SectionResponse>> GetAll(Guid goalId);
}
