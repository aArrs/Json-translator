using Newtonsoft.Json.Linq;

namespace LocalizationForm.Interfaces;

public interface ICastJObject
{
    JObject GetJObject(string json);
}

public class CastJObject : ICastJObject
{
    public JObject GetJObject(string json)
    {
        return JObject.Parse(json);
    }
}