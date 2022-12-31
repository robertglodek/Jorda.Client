using Jorda.Client.Common.Services.Goal.Models.Requests;
using Jorda.Client.Common.Services.Goal.Models.Responses;

namespace Jorda.Client.Services.Goal;

public class GoalService : IGoalService
{
    private IHttpService _httpService;

    public GoalService(IHttpService httpService)
    {
        _httpService = httpService;
    }

    public async Task<Guid> Create(CreateGoalRequest request)
    {
        return await _httpService.Post<Guid>("/goal", request);
    }

    public async Task Delete(Guid id)
    {
        await _httpService.Delete($"/goal/{id}");
    }

    public async Task<IEnumerable<GoalResponse>> GetAll()
    {
        return await _httpService.Get<IEnumerable<GoalResponse>>("/goal");
    }

    public async Task<GoalResponse> GetById(Guid id)
    {
        return await _httpService.Get<GoalResponse>($"/goal/{id}");
    }

    public async Task Update(UpdateGoalRequest request)
    {
        await _httpService.Put($"/goal/{request.Id}", request);
    }
}
