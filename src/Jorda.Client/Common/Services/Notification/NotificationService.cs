using Jorda.Client.Common.Services.Notification.Models.Requests;
using Jorda.Client.Common.Services.Notification.Models.Responses;

namespace Jorda.Client.Services.Notification;

public class NotificationService : INotificationService
{

    private IHttpService _httpService;

    public NotificationService(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<Guid> Create(CreateNotificationRequest request)
    {
        return await _httpService.Post<Guid>("/notification", request);
    }

    public async Task Delete(Guid id)
    {
        await _httpService.Delete($"/notification/{id}");
    }

    public async Task<IEnumerable<NotificationResponse>> GetAll()
    {
        return await _httpService.Get<IEnumerable<NotificationResponse>>("/notification");
    }

    public async Task<NotificationResponse> GetById(Guid id)
    {
        return await _httpService.Get<NotificationResponse>($"/notification/{id}");
    }

    public async Task Update(UpdateNotificationRequest request)
    {
        await _httpService.Put($"/notification/{request.Id}", request);
    }
}
