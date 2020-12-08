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

namespace SimpleFileManager
{
    public partial class Form2 : Form
    {
        public string name;
        public Form2(string filePath)
        {
            InitializeComponent();
            name = filePath;
            label1.Text = name;
            this.FormClosing += new FormClosingEventHandler(Form2_FormClosing);
            /* File.OpenRead(filePath);
             StreamReader sr = new StreamReader(filePath);*/

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Хочете зберегти зміни?", "Зберегти файл", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText(name, richTextBox1.Text);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText(name);
            richTextBox1.Text = text;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
