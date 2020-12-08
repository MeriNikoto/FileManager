using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleFileManager
{
    public partial class Form3 : Form
    {
        List<string> list;
        string filePath;
        Facade facade = new Facade();
        public Form3(List<string> l, string path)
        {
            InitializeComponent();
            list = l;
            filePath = path;
            string text = "";
            foreach(var item in l)
            {
                text = text + item + "\n";
                comboBox1.Items.Add(item);
            }
            richTextBox1.Text = text;
        }
        private void richTextBox1Update()
        {
            string text = "";
            foreach (var item in list)
            {
                text = text + item + "\n";
                //comboBox1.Items.Add(item);
            }
            richTextBox1.Text = text;
        }
        private void comboBoxUpgrade()
        {
            comboBox1.Items.Clear();
            foreach (var item in list)
            {
                comboBox1.Items.Add(item);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            facade.DeleteTag(filePath, comboBox1.Text);
            int k = comboBox1.Items.IndexOf(comboBox1.Text);
            list.Remove(comboBox1.Text);
            comboBox1.Items.RemoveAt(k);
            comboBox1.Text = "";
            richTextBox1Update();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            facade.ChangeTag(filePath, comboBox1.Text, textBox2.Text);
            int k = list.IndexOf(comboBox1.Text);
            list[k] = textBox2.Text;
            comboBoxUpgrade();
            richTextBox1Update();
            comboBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
