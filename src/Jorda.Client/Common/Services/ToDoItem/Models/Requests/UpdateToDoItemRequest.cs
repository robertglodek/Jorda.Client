using Jorda.Client.Common.Enums;

namespace Jorda.Client.Common.Services.ToDoItem.Models.Requests;

public class UpdateToDoItemRequest
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public Interval Interval { get; set; }
    public PriorityLevel PriorityLevel { get; set; }
    public DateTime? DueDateUtc { get; set; }
    public Guid SectionId { get; set; }
    public bool Done { get; set; }
}
