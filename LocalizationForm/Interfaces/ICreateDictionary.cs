using Newtonsoft.Json.Linq;

namespace LocalizationForm.Interfaces;

public interface ICreateDictionary
{
    Dictionary<string, string> CreateDictionary(Dictionary<string, string> sourceStrings, JObject json);
}

public class DictionaryCreator : ICreateDictionary
{
    public Dictionary<string, string> CreateDictionary(Dictionary<string, string> sourceStrings, JObject json)
    {
        sourceStrings.Clear();
        
        foreach (var property in json)
        {
            sourceStrings[property.Key] = property.Value.ToString();
        }
        
        return sourceStrings;
    }
}