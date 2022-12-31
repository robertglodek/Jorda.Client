using Jorda.Client.Common.Services;
using Jorda.Client.Common.Services.Note.Models.Requests;
using Jorda.Client.Common.Services.Note.Models.Responses;

namespace Jorda.Client.Services.Note;

public interface INoteService
{
    Task Delete(Guid id, Guid sectionId);
    Task<Guid> Create(CreateNoteRequest request);
    Task Update(UpdateNoteRequest request);
    Task<NoteResponse> GetById(Guid id, Guid sectionId);
    Task<PagedResult<NoteResponse>> GetAll(GetNotesRequest request);
}
