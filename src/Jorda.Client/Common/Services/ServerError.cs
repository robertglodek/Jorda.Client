namespace Jorda.Client.Common.Services
{
    public class ServerError
    {
        public int Status { get; set; }

        public string Title { get; set; } = null!;

        public string Type { get; set; } = null!;

        public string? Details { get; set; }

        public Dictionary<string, string[]>? Errors { get; set; }

        public IEnumerable<string>? FailureMessages { get; set; }
    }
}
