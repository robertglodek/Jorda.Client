using Blazored.LocalStorage;
using Jorda.Client.Common.Constants;
using Jorda.Client.Common.Services.Identity.Models.Requests;
using Microsoft.AspNetCore.Components;

namespace Jorda.Client.Services.Identity;

public class AuthService : IAuthService
{
    private IHttpService _httpService;
    private NavigationManager _navigationManager;
    private ILocalStorageService _localStorageService;

    public string? Token { get; private set; }

    public AuthService(IHttpService httpService, NavigationManager navigationManager,
        ILocalStorageService localStorageService)
    {
        _httpService = httpService;
        _navigationManager = navigationManager;
        _localStorageService = localStorageService;
    }

    public async Task InitializeAsync()
    {
        Token = await _localStorageService.GetItemAsync<string>(StorageConstants.AuthToken);
    }

    public async Task Login(TokenRequest request)
    {
        Token = await _httpService.Post<string>("/api/identity/token", request);
        await _localStorageService.SetItemAsync(StorageConstants.AuthToken, Token);
    }

    public async Task Logout()
    {
        Token = null;
        await _localStorageService.RemoveItemAsync(StorageConstants.AuthToken);
        _navigationManager.NavigateTo("login");
    }
}
