using Jorda.Client.Common.Extensions;
using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.Note.Models.Requests;
using Jorda.Client.Common.Services.Note.Models.Responses;
using Microsoft.AspNetCore.WebUtilities;

namespace Jorda.Client.Services.Note;

public class NoteService : INoteService
{
    private IHttpService _httpService;

    public NoteService(IHttpService httpService)
    {
        _httpService = httpService;
    }
    public async Task<Guid> Create(CreateNoteRequest request)
    {
        return await _httpService.Post<Guid>($"/section/{request.SectionId}/note", request);
    }

    public async Task Delete(Guid id, Guid sectionId)
    {
        await _httpService.Delete($"/section/{sectionId}/note/{id}");
    }

    public async Task<PagedResult<NoteResponse>> GetAll(GetNotesRequest request)
    {
        return await _httpService.Get<PagedResult<NoteResponse>>(QueryHelpers.AddQueryString($"/section/{request.SectionId}/note", request.ToDictionary()));
    }

    public async Task<NoteResponse> GetById(Guid id, Guid sectionId)
    {
        return await _httpService.Get<NoteResponse>($"/section/{sectionId}/note/{id}");
    }

    public async Task Update(UpdateNoteRequest request)
    {
        await _httpService.Put($"/section/{request.SectionId}/note/{request.Id}", request);
    }
}
