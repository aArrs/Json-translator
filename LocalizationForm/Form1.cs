using LocalizationForm.Interfaces;
using GTranslate.Translators;
using Newtonsoft.Json.Linq;

namespace LocalizationForm
{
    public partial class Form1 : Form
    {
        GoogleTranslator translator = new GoogleTranslator();
        
        private readonly IGetFileText _getFileText = new GetFileText();
        private readonly ICastJObject _castJObject = new CastJObject();
        private readonly ITranslate _translate = new JsonTranslator();
        private readonly ICreateJson _createJson = new JsonCreator();
        
        JObject sourceStrings = null;
        private string language = null;
        string translatedStrings = null;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = null;
            richTextBox1.Text = _getFileText.GetText();
            sourceStrings = _castJObject.GetJObject(richTextBox1.Text);
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            translatedStrings = await _translate.TranslateStrings(translator, sourceStrings, language);
            richTextBox2.Text = translatedStrings;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem != null)
            {   
                language = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            }
        }
        private void button3_Click_1(object sender, EventArgs e)
        {  
            _createJson.CreateJson(translatedStrings, _getFileText.fileName, language);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            richTextBox2.Text = null;
            comboBox1.SelectedItem = null;
            comboBox1.Text = "Language";
            language = null;
            translatedStrings = null;
            sourceStrings = null;
        }

    }
}

