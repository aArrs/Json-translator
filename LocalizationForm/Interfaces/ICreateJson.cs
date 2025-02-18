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
                throw new Exception("File already exists.");
            }
            else if (fileName == null)
            {
                throw new Exception("Please choose file.");
            }
            else if (translatedStrings == null)
            {
                throw new Exception("Please translate file first.");
            }
            else if (toLanguage == null)
            {
                throw new Exception("Please choose language.");
            }
            else
            {
                using (File.Create(filePath)){}
                File.WriteAllText(filePath, translatedStrings);
                MessageBox.Show("Translated file is saved successfully");
            }
        }
        catch
        {
            throw;
        }
                
    }
}