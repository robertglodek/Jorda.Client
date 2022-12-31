using Jorda.Client.Common.Services.Identity.Models.Requests;

namespace Jorda.Client.Services.Identity;

public interface IAuthService
{
    string? Token { get; }
    Task InitializeAsync();
    Task Login(TokenRequest request);
    Task Logout();
}
