using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsFormsApp1.Interfaces;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IGetFileText _getFileText = new GetFileText();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = _getFileText.GetText();
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}