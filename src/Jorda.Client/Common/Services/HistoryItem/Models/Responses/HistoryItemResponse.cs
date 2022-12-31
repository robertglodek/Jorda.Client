namespace Jorda.Client.Common.Services.HistoryItem.Models.Responses
{
    public class HistoryItemResponse
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = null!;
        public Enums.TaskStatus TaskStatus { get; set; }
        public DateTime Created { get; set; }
    }
}
