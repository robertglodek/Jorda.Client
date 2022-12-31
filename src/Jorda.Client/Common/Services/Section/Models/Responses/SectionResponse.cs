namespace Jorda.Client.Common.Services.Section.Models.Responses;

public class SectionResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public Guid GoalId { get; set; }
}
