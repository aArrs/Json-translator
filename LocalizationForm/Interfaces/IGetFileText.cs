namespace LocalizationForm.Interfaces
{
    interface IGetFileText
    {
        string GetText();
        public string fileName { get; set; }
    }

    public class GetFileText: IGetFileText
    {
        public string fileName { get; set; } = null;
        
        public string GetText()
        {
            fileName = null;
            var fileText = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            try
            {
                
                if (openFile.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("Выберите файл.");
                }
                else
                {
                    fileText = File.ReadAllText(openFile.FileName);
                    fileName = Path.GetFileNameWithoutExtension(openFile.FileName);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            
            return fileText;
        }
    }
}