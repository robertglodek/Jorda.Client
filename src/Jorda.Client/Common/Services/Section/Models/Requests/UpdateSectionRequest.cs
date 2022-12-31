namespace Jorda.Client.Common.Services.Section.Models.Requests;

public class UpdateSectionRequest
{
    public Guid GoalId { get; set; }
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
}
