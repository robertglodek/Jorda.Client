
namespace Jorda.Client.Common.Services.UserFile.Models.Requests;

public class CreateUserFileRequest
{
    public Guid GoalId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
