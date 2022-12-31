using Jorda.Client.Common.Constants.Localization;
using Jorda.Client.Common.Resources;

namespace Jorda.Client.Common.Constants
{
    public static class LocalizationConstants
    {
        public static readonly LanguageCode[] SupportedLanguages = {
            new LanguageCode
            {
                Code = "en-US",
                DisplayName = Languages.English
            }, 
            new LanguageCode
            {
                Code = "pl-PL",
                DisplayName = Languages.Polish
            }
        };
    }
}
