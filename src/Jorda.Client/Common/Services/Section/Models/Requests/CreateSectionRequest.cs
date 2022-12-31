namespace Jorda.Client.Common.Services.Section.Models.Requests;

public class CreateSectionRequest
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public Guid GoalId { get; set; }
}
