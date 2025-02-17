using GTranslate.Translators;
using Newtonsoft.Json.Linq;

namespace LocalizationForm.Interfaces
{
    public interface ITranslate
    {
        /*public Task<Dictionary<string, string>> TranslateStrings(GoogleTranslator client, Dictionary<string, string> sourceStrings);*/
        public Task<string> TranslateStrings(GoogleTranslator client, JObject sourceStrings, string toLanguage);

            //public Task<JArray> TranslatesStrings(GoogleTranslator client, JArray sourceStrings);
    }

    public class JsonTranslator : ITranslate
    {
        public async Task<string> TranslateStrings(GoogleTranslator client, JObject sourceStrings, string toLanguage)
        {
            try
            {
                if (sourceStrings == null)
                {
                    throw new Exception("Please choose file to translate.");
                }
                else if (toLanguage == null)
                {
                    throw new Exception("Please choose language.");
                }
                else
                {
                    foreach (var property in sourceStrings)
                    {
                        sourceStrings[property.Key] =
                            (await client.TranslateAsync(property.Value.ToString(), toLanguage, "ru")).Translation;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return sourceStrings.ToString();
        }
    }
}

