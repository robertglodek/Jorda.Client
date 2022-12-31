namespace Jorda.Client.Common.Services.Notification.Models.Responses;

public class NotificationResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool Active { get; set; }
}
