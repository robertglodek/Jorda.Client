using Jorda.Client.Common.Enums;

namespace Jorda.Client.Common.Services.Notification.Models.Requests
{
    public class UpdateNotificationRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool Active { get; set; }
        public ImportanceLevel ImportanceLevel { get; set; }
    }
}
