using Blazored.LocalStorage;
using Jorda.Client.Common.Configuration;
using Jorda.Client.Common.Constants;
using Microsoft.AspNetCore.Components;
using System.Globalization;

namespace Jorda.Client.Services;

public class ClientPreferenceService : IClientPreferenceService
{
    
    private ILocalStorageService _localStorageService;
    public ClientPreference ClientPreference { get; private set; }

    public ClientPreferenceService(ILocalStorageService localStorageService)
    {
        ClientPreference = new ClientPreference();
        _localStorageService = localStorageService;
    }

    public async Task InitializeAsync()
    {
        var clientPreference = await _localStorageService.GetItemAsync<ClientPreference>(StorageConstants.ClientPreference);
        if(clientPreference != null)
            ClientPreference = clientPreference;

        CultureInfo culture = new CultureInfo(ClientPreference!.LanguageCode);
        CultureInfo.DefaultThreadCurrentCulture = culture;
        CultureInfo.DefaultThreadCurrentUICulture = culture;
    }

    public async Task<bool> ToggleDarkModeAsync()
    {
        ClientPreference.IsDarkMode = !ClientPreference.IsDarkMode;
        await _localStorageService.SetItemAsync(StorageConstants.ClientPreference, ClientPreference);
        return !ClientPreference.IsDarkMode;
    }

    public async Task ChangeLanguageAsync(string languageCode)
    {
        ClientPreference.LanguageCode = languageCode;
        await _localStorageService.SetItemAsync(StorageConstants.ClientPreference, ClientPreference);
    }
}
