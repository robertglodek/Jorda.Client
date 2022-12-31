namespace Jorda.Client.Common.Extensions
{
    public static class DictionaryExtensions
    {
        public static Dictionary<string, string> ToDictionary(this object model, string[]? ignoredProperties=null)
        {
            Dictionary<string, string> dictionary = new();

            foreach (var property in model.GetType().GetProperties())
            {
                if(ignoredProperties != null && ignoredProperties.Contains(property.Name))
                {
                    continue;
                }

                var value = property.GetValue(model);
                if (value != null)
                {
                    dictionary.Add(property.Name, value.ToString()!);
                }
            }

            return dictionary;
        }
    }
}
