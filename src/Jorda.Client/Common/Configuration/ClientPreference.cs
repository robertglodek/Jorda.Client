using Jorda.Client.Common.Constants;

namespace Jorda.Client.Common.Configuration;

public class ClientPreference
{
    public bool IsDarkMode { get; set; } = false;
   
    public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()!.Code;
}
