namespace LocalizationForm.Interfaces;

public interface ICreateJson
{
    public void CreateJson(string translatedStrings, string fileName, string language);
}

public class JsonCreator : ICreateJson
{
    public async void CreateJson(string translatedStrings, string fileName, string toLanguage)
    {
        var username = Environment.UserName;
        var filePath = "C:\\Users\\" + username + $"\\Documents\\{fileName}_{toLanguage}.json";
        try
        {
            if (File.Exists(filePath))
            {
                throw new Exception("Такой файл уже существует.");
            }
            else if (fileName == null)
            {
                throw new Exception("Выберите файл для перевода.");
            }
            else if (translatedStrings == null)
            {
                throw new Exception("Сначала переведите файл.");
            }
            else if (toLanguage == null)
            {
                throw new Exception("Выберите язык.");
            }
            else
            {
                using (File.Create(filePath)){}
                File.WriteAllText(filePath, translatedStrings);
                MessageBox.Show("Файл успешно сохранен.");
            }
        }
        catch
        {
            throw;
        }
                
    }
}