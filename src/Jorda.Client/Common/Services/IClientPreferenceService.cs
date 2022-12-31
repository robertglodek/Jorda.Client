using Jorda.Client.Common.Configuration;

namespace Jorda.Client.Services;

public interface IClientPreferenceService
{
    Task InitializeAsync();
    Task<bool> ToggleDarkModeAsync();
    Task ChangeLanguageAsync(string languageCode);
}
