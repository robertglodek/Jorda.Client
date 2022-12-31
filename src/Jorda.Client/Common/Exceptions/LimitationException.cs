namespace Jorda.Client.Common.Exceptions
{
    public class LimitationException : Exception
    {
        public LimitationException(string details)
        {
            Details = details;
        }
        public string Details { get; }
    }
}
