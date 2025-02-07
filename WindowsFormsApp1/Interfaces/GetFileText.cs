using System.Windows.Forms;
using  WindowsFormsApp1;
using System.IO;

namespace WindowsFormsApp1.Interfaces
{
    interface IGetFileText
    {
        string GetText();
    }

    public class GetFileText: IGetFileText
    {
        public string GetText()
        {
            string fileText = string.Empty;
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileText = File.ReadAllText(openFile.FileName);
            }
            return fileText;
        }
    }
}