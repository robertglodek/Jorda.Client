using Jorda.Client.Common.Enums;

namespace Jorda.Client.Common.Services.ToDoItem.Models.Requests
{
    public class CreateToDoItemRequest
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public Interval Interval { get; set; }
        public PriorityLevel PriorityLevel { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid SectionId { get; set; }
    }
}
