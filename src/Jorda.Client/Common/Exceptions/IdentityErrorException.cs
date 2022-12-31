namespace Jorda.Client.Common.Exceptions
{
    public class IdentityErrorException : Exception
    {
        public IdentityErrorException(IEnumerable<string> errors)
        {
            Errors = errors.ToArray();
        }
        public IEnumerable<string> Errors { get; set; }
    }
}
