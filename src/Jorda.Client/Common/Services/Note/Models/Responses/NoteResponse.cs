namespace Jorda.Client.Common.Services.Note.Models.Responses;

public class NoteResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? Source { get; set; }
    public Guid SectionId { get; set; }
}
