namespace Jorda.Client.Common.Services.Identity.Models.Requests;

public class TokenRequest
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
}

