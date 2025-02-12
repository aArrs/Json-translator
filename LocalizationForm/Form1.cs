using LocalizationForm.Interfaces;
using GTranslate.Translators;

namespace LocalizationForm
{
    public partial class Form1 : Form
    {
        GoogleTranslator _translator = new GoogleTranslator();
        
        private readonly IGetFileText _getFileText = new GetFileText();
        private readonly ICastJObject _castJObject = new CastJObject();
        private readonly ICreateDictionary _createDictionary = new DictionaryCreator();
        private readonly ITranslate _translate = new JsonTranslator();
        
        Dictionary<string, string> _sourceStrings = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _getFileText.GetText();
            
            _sourceStrings = _createDictionary.CreateDictionary(_sourceStrings, _castJObject.GetJObject(richTextBox1.Text));
            
            var translated = await _translate.TranslateStrings(_translator, _sourceStrings);
            
            foreach (var prop in translated)
            {
                Console.WriteLine(prop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}

