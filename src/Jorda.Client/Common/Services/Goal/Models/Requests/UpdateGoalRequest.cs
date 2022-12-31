namespace Jorda.Client.Common.Services.Goal.Models.Requests;

public class UpdateGoalRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string ColourHex { get; set; } = null!;
    public string? Description { get; set; }
}
