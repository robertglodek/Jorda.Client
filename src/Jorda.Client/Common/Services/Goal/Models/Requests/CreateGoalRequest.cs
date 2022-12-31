namespace Jorda.Client.Common.Services.Goal.Models.Requests;

public class CreateGoalRequest
{
    public string Name { get; set; } = null!;
    public string ColourHex { get; set; } = null!;
    public string? Description { get; set; }
}
