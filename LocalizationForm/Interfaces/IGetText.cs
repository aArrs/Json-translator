using Newtonsoft.Json.Linq;
using System.IO;

namespace LocalizationForm.Interfaces
{
    interface IGetFileText
    {
        string GetText();
    }

    public class GetFileText: IGetFileText
    {
        public string GetText()
        {
            var fileText = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();

            try
            {
                openFile.ShowDialog();
                fileText = File.ReadAllText(openFile.FileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            return fileText;
        }
    }
}