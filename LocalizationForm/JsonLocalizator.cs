using LocalizationForm.Interfaces;
using GTranslate.Translators;
using Newtonsoft.Json.Linq;

namespace LocalizationForm
{ 
    partial class JsonLocalizator : Form
    {
        YandexTranslator translatorYandex = new YandexTranslator();
        GoogleTranslator2 translatorGoogle = new GoogleTranslator2();
        
        private readonly IGetFileText _getFileText;
        private readonly ICastJObject _castJObject;
        private readonly ITranslate _translate;
        private readonly ICreateJson _createJson;
        
        JObject sourceStrings = null;
        private string language = null;
        string translatedStrings = null;
        
        public JsonLocalizator(IGetFileText getFileText, ICastJObject castJObject, ITranslate translate,  ICreateJson createJson)
        {
            _getFileText = getFileText;
            _castJObject = castJObject;
            _translate = translate;
            _createJson = createJson;
            InitializeComponent();
        }
        private void JsonTranslator_Load(object sender, EventArgs e) {}
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
                    translatedStrings = await _translate.ParseJObjectYa(translatorYandex, sourceStrings, language);
                }
                else
                {
                    translatedStrings = await _translate.ParseJObjectGo(translatorGoogle, sourceStrings, language);
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

