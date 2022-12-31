using Jorda.Client.Common.Services.Note.Models.Requests;
using Jorda.Client.Common.Services.Note.Models.Responses;
using Jorda.Client.Common.Services;
using Microsoft.AspNetCore.WebUtilities;
using Jorda.Client.Common.Services.Section.Models.Requests;
using Jorda.Client.Common.Services.Section.Models.Responses;

namespace Jorda.Client.Services.Section;

public class SectionService:ISectionService
{
    private IHttpService _httpService;

    public SectionService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<Guid> Create(CreateSectionRequest request)
    {
        return await _httpService.Post<Guid>($"/goal/{request.GoalId}/section", request);
    }

    public async Task Delete(Guid id, Guid goalId)
    {
        await _httpService.Delete($"/goal/{goalId}/section/{id}");
    }

    public async Task<IEnumerable<SectionResponse>> GetAll(Guid goalId)
    {
        return await _httpService.Get<IEnumerable<SectionResponse>>($"/goal/{goalId}/section");
    }

    public async Task<SectionResponse> GetById(Guid id, Guid goalId)
    {
        return await _httpService.Get<SectionResponse>($"/goal/{goalId}/section/{id}");
    }

    public async Task Update(UpdateSectionRequest request)
    {
        await _httpService.Put($"/goal/{request.GoalId}/section/{request.Id}", request);
    }
}
