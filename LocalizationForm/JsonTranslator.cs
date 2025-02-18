using LocalizationForm.Interfaces;
using GTranslate.Translators;
using Newtonsoft.Json.Linq;

namespace LocalizationForm
{
    public partial class JsonTranslator : Form
    {
        YandexTranslator translator = new YandexTranslator();
        GoogleTranslator2 translator2 = new GoogleTranslator2();
        
        private readonly IGetFileText _getFileText = new GetFileText();
        private readonly ICastJObject _castJObject = new CastJObject();
        private readonly ITranslate _translate = new Interfaces.JsonTranslator();
        private readonly ICreateJson _createJson = new JsonCreator();
        
        JObject sourceStrings = null;
        List<JObject> sourceStringsList = null;
        private string language = null;
        string translatedStrings = null;
        
        public JsonTranslator()
        {
            InitializeComponent();
        }
        private void JsonTranslator_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Maximized;
            TopMost = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = null;
            richTextBox1.Text = _getFileText.GetText();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            sourceStrings = _castJObject.GetJObject(richTextBox1.Text);
            try
            {
                if(language == "be")
                {
                    if ((sourceStrings.First).First.HasValues)
                    {
                        translatedStrings = await _translate.TranslateNestedStringsYa(translator, sourceStrings, language);
                    }
                    else
                    {
                        translatedStrings = await _translate.TranslateStringsYa(translator, sourceStrings, language);
                    }
                }
                else
                {
                    if ((sourceStrings.First).First.HasValues)
                    {
                        translatedStrings = await _translate.TranslateNestedStringsGo(translator2, sourceStrings, language);
                    }
                    else
                    {
                        translatedStrings = await _translate.TranslateStringsGo(translator2, sourceStrings, language);
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
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

