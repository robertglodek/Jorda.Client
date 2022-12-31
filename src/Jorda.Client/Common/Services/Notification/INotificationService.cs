 using Jorda.Client.Common.Services.Notification.Models.Requests;
using Jorda.Client.Common.Services.Notification.Models.Responses;

namespace Jorda.Client.Services.Notification;

public interface INotificationService
{
    Task Delete(Guid id);
    Task<Guid> Create(CreateNotificationRequest request);
    Task Update(UpdateNotificationRequest request);
    Task<NotificationResponse> GetById(Guid id);
    Task<IEnumerable<NotificationResponse>> GetAll();
}
