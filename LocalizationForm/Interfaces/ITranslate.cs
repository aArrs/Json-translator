using GTranslate.Translators;
using Newtonsoft.Json.Linq;

namespace LocalizationForm.Interfaces
{
    public interface ITranslate
    {
        public Task<string> TranslateJsonGo(GoogleTranslator2 client, JObject sourceStrings, string toLanguage);
        public Task<string> TranslateJsonYa(YandexTranslator client, JObject sourceStrings, string toLanguage);
    }

    public class JsonTranslator : ITranslate
    {
        public async Task<string> TranslateJsonGo(GoogleTranslator2 client, JObject sourceStrings, string toLanguage)
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
                    foreach (var property in sourceStrings.Properties())
                    {
                        if (property.Value.Type == JTokenType.Object)
                        {
                            await TranslateJsonGo(client, (JObject)property.Value, toLanguage);
                        }
                        else if (property.Value.Type == JTokenType.Array)
                        {
                            foreach (var item in (JArray)property.Value)
                            {
                                if (item.Type == JTokenType.Object)
                                {
                                    await TranslateJsonGo(client, (JObject)item, toLanguage);
                                }
                            }
                        }
                        else
                        {
                            property.Value =
                                (await client.TranslateAsync(property.Value.ToString(), toLanguage, "ru"))
                                .Translation;
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
        public async Task<string> TranslateJsonYa(YandexTranslator client, JObject sourceStrings, string toLanguage)
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
                    foreach (var property in sourceStrings.Properties())
                    {
                        if (property.Value.Type == JTokenType.Object)
                        {
                            await TranslateJsonYa(client, (JObject)property.Value, toLanguage);
                        }
                        else if (property.Value.Type == JTokenType.Array)
                        {
                            foreach (var item in (JArray)property.Value)
                            {
                                if (item.Type == JTokenType.Object)
                                {
                                    await TranslateJsonYa(client, (JObject)item, toLanguage);
                                }
                            }
                        }
                        else
                        {
                            property.Value =
                                (await client.TranslateAsync(property.Value.ToString(), toLanguage, "ru"))
                                .Translation;
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

