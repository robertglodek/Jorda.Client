using Jorda.Client.Common.Services.Goal.Models.Requests;
using Jorda.Client.Common.Services.Goal.Models.Responses;

namespace Jorda.Client.Services.Goal;

public interface IGoalService
{
    Task Delete(Guid id);
    Task<Guid> Create(CreateGoalRequest request);
    Task Update(UpdateGoalRequest request);
    Task<GoalResponse> GetById(Guid id);
    Task<IEnumerable<GoalResponse>> GetAll();
}
