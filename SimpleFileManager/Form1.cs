using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleFileManager
{
    public partial class Form1 : Form
    {
        private string filePath1 = "D:";
        private string filePath2 = "C:/";
        private FileManager fileManager = new FileManager();
        private Facade facade = new Facade();
        private bool isFile = false;
        private bool isChanged = false;
        private bool isCopiedFile = false;
        private string currentlySelectedItemName = "";
        public Form1()
        {
            InitializeComponent();
            
        }
         
        private void Form1_Load(object sender, EventArgs e)
        {
            filePathTextBox1.Text = filePath1;
            fileManager.LoadFiles(filePath1, listView1, isFile, currentlySelectedItemName);
            currentlySelectedItemName = "";
            isFile = false;
            filePathTextBox2.Text = filePath2;
            fileManager.LoadFiles(filePath2, listView2, isFile, currentlySelectedItemName);
        }
       
        private void Rename()
        {
            
                listView1.SelectedItems[0].BeginEdit();
                isChanged = true;
           
        }
     
       
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(isChanged)
            {
                facade.Rename(isFile, filePath1 + "/" + currentlySelectedItemName, filePath1 + "/" + e.Item.Text);
                fileManager.loadButtonAction(filePath1, listView1, false, "");
                isChanged = false;
            }
            currentlySelectedItemName = e.Item.Text;
            FileAttributes fileAttr = File.GetAttributes(filePath1 + "/" + currentlySelectedItemName);
            if((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
               
            }
            else
            {
                isFile = true;
            }
            filePathTextBox1.Text = filePath1 + "/" + currentlySelectedItemName;
        }
        private void listView2_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            currentlySelectedItemName = e.Item.Text;

            FileAttributes fileAttr = File.GetAttributes(filePath2 + "/" + currentlySelectedItemName);
            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                isFile = false;
                filePathTextBox2.Text = filePath2 + "/" + currentlySelectedItemName;
            }
            else
            {
                isFile = true;
            }
        }
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            filePath1 = fileManager.loadButtonAction(filePath1 + "/" + currentlySelectedItemName, listView1, isFile, currentlySelectedItemName);
            isFile = false;
        }
        private void listView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            filePath2 = fileManager.loadButtonAction(filePath2 + "/" + currentlySelectedItemName, listView2, isFile, currentlySelectedItemName);
            isFile = false;
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            string t = filePath1;
            isFile = false;
            filePath1 = fileManager.loadButtonAction(fileManager.GoBack(listView1, t), listView1, isFile, "");
            filePathTextBox1.Text = filePath1;
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            string t = filePathTextBox2.Text;
            string temp = fileManager.GoBack(listView2, t);
            isFile = false;
            filePath2 = fileManager.loadButtonAction(temp, listView2, isFile, "");
            filePathTextBox2.Text = filePath2;
        }
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && listView1.SelectedItems.Count > 0)
            {
                contextMenuStrip1.Show(this, new Point(e.X, e.Y));
            }
           
            
        }

        private void ВидалитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити це? Подумайте, ви вже видалили Айзека, воно вам треба?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                facade.Delete(isFile, filePath1 + "/" + currentlySelectedItemName);
                isFile = false;
                fileManager.loadButtonAction(filePath1, listView1, isFile, "");
            }
        }

        private void ПерейменуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rename();
        }

        private void СкопіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facade.Copy(isFile, filePath1, currentlySelectedItemName);
            if (isFile)
            {
               
                isCopiedFile = true;
            }
            else
            {
                isCopiedFile = false;
            }
                
        }

        private void ВставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                facade.Paste(isCopiedFile, filePath1);
                isCopiedFile = false;
            }
            catch(IOException)
            {
                MessageBox.Show("Помилка копіювання");
            }
            fileManager.loadButtonAction(filePath1, listView1, isFile, "");
        }
        private void ФайлtxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facade.Create(true, filePath1);
            fileManager.loadButtonAction(filePath1, listView1, false, "");
        }

        private void ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void ПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            facade.Create(false, filePath1);
            isFile = false;
            fileManager.loadButtonAction(filePath1, listView1, false, "");
        }

        private void РедагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(filePath1 + "/" + currentlySelectedItemName);
            form.Show();
        }

   
        private void СписокТегівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  List<string> temp = new List<string>();
              temp = facade.MakeTagList(filePath1 + "/" + currentlySelectedItemName);*/
            if (currentlySelectedItemName.Contains(".html"))
            {
                Form3 form = new Form3(facade.MakeTagList(filePath1 + "/" + currentlySelectedItemName), filePath1 + "/" + currentlySelectedItemName);
                form.Show();
            }
           

        }

        private void ВставитиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            facade.Paste(isCopiedFile, filePath1);
            fileManager.loadButtonAction(filePath1, listView1, isFile, "");
        }

        private void ПапкуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            facade.Create(false, filePath1);
            isFile = false;
            fileManager.loadButtonAction(filePath1, listView1, false, "");
        }

        private void ФайлtxtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            facade.Create(true, filePath1);
            fileManager.loadButtonAction(filePath1, listView1, false, "");
        }

        private void ПеретворитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ChangeText();
        }
    }
}
