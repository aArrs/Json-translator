using LocalizationForm.Interfaces;

namespace LocalizationForm
{
    public partial class Form1 : Form
    {
        private readonly IGetFileText _getFileText = new GetFileText();
        private readonly ICastJObject _castJObject = new CastJObject();
        private readonly ICreateDictionary _createDictionary = new DictionaryCreator();
        
        Dictionary<string, string> sourceStrings = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _getFileText.GetText();
            
            sourceStrings = _createDictionary.CreateDictionary(sourceStrings, _castJObject.GetJObject(richTextBox1.Text));
            
            foreach (var prop in sourceStrings)
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

