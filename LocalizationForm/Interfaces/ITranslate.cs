using GTranslate.Translators;

namespace LocalizationForm.Interfaces
{
    public interface ITranslate
    {
        public Task<Dictionary<string, string>> TranslateStrings(GoogleTranslator client, Dictionary<string, string> sourceStrings);
    }

    public class JsonTranslator : ITranslate
    {
        public async Task<Dictionary<string, string>> TranslateStrings(GoogleTranslator client, Dictionary<string, string> sourceStrings)
        {
            foreach (var property in sourceStrings)
            {
                sourceStrings[property.Key] = (await client.TranslateAsync(property.Value.ToString(), "en", "ru")).Translation;
            }
            return sourceStrings;
        }
    }
}

