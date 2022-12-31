using Jorda.Client.Common.Enums;

namespace Jorda.Client.Common.Services.Notification.Models.Requests;

public class CreateNotificationRequest
{
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool Active { get; set; }
    public ImportanceLevel ImportanceLevel { get; set; }
}
