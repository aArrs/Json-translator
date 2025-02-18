using GTranslate.Translators;
using Newtonsoft.Json.Linq;

namespace LocalizationForm.Interfaces
{
    public interface ITranslate
    {
        public Task<string> TranslateStringsYa(YandexTranslator client, JObject sourceStrings, string toLanguage);
        public Task<string> TranslateStringsGo(GoogleTranslator2 client, JObject sourceStrings, string toLanguage);
        public Task<string> TranslateNestedStringsYa(YandexTranslator client, JObject sourceStrings, string toLanguage);
        public Task<string> TranslateNestedStringsGo(GoogleTranslator2 client, JObject sourceStrings, string toLanguage);
    }

    public class JsonTranslator : ITranslate
    {
        public async Task<string> TranslateStringsYa(YandexTranslator client, JObject sourceStrings, string toLanguage)
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
        
        public async Task<string> TranslateStringsGo(GoogleTranslator2 client, JObject sourceStrings, string toLanguage)
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
        
        public async Task<string> TranslateNestedStringsYa(YandexTranslator client, JObject sourceStrings, string toLanguage)
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
                    foreach (var obj in sourceStrings)
                    {
                        foreach (JProperty property in obj.Value)
                        {
                            property.Value =
                                (await client.TranslateAsync(property.Value.ToString(), toLanguage, "ru")).Translation;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return sourceStrings.ToString();
        }
        
        public async Task<string> TranslateNestedStringsGo(GoogleTranslator2 client, JObject sourceStrings, string toLanguage)
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
                    foreach (var obj in sourceStrings)
                    {
                        foreach (JProperty property in obj.Value)
                        {
                            property.Value =
                                (await client.TranslateAsync(property.Value.ToString(), toLanguage, "ru")).Translation;
                        }
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

