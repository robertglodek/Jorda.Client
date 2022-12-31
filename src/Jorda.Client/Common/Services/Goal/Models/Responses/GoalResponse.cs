namespace Jorda.Client.Common.Services.Goal.Models.Responses;

public class GoalResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string Colour { get; set; } = null!;
    public string UserId { get; set; } = null!;
    public string? Description { get; set; }
}
