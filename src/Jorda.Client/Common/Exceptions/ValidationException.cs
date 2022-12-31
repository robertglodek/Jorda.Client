
namespace Jorda.Client.Common.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(IDictionary<string, string[]> errors)
        {
            Errors = errors;
        }
        public IDictionary<string, string[]> Errors { get; }
    }
}
