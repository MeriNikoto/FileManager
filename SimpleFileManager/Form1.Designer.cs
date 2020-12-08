namespace SimpleFileManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backButton = new System.Windows.Forms.Button();
            this.Back2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.iconList = new System.Windows.Forms.ImageList(this.components);
            this.filePathTextBox1 = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.filePathTextBox2 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.видалитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редагуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокТегівToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.створитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.папкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.файлtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейменуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(3, 13);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Back2
            // 
            this.Back2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Back2.Location = new System.Drawing.Point(1223, 11);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(63, 23);
            this.Back2.TabIndex = 1;
            this.Back2.Text = "Back";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.iconList;
            this.listView1.Location = new System.Drawing.Point(3, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(625, 550);
            this.listView1.SmallImageList = this.iconList;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // iconList
            // 
            this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
            this.iconList.TransparentColor = System.Drawing.Color.Transparent;
            this.iconList.Images.SetKeyName(0, "folder.png");
            this.iconList.Images.SetKeyName(1, "folder2.png");
            this.iconList.Images.SetKeyName(2, "file.png");
            this.iconList.Images.SetKeyName(3, "doc.png");
            this.iconList.Images.SetKeyName(4, "pdf.png");
            this.iconList.Images.SetKeyName(5, "mp3.png");
            this.iconList.Images.SetKeyName(6, "mp4.png");
            this.iconList.Images.SetKeyName(7, "exe.png");
            this.iconList.Images.SetKeyName(8, "unknown.png");
            this.iconList.Images.SetKeyName(9, "png.png");
            this.iconList.Images.SetKeyName(10, "folder64.png");
            this.iconList.Images.SetKeyName(11, "28878.png");
            // 
            // filePathTextBox1
            // 
            this.filePathTextBox1.Location = new System.Drawing.Point(84, 13);
            this.filePathTextBox1.Name = "filePathTextBox1";
            this.filePathTextBox1.Size = new System.Drawing.Size(544, 22);
            this.filePathTextBox1.TabIndex = 3;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.HideSelection = false;
            this.listView2.LargeImageList = this.iconList;
            this.listView2.Location = new System.Drawing.Point(634, 41);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(652, 550);
            this.listView2.SmallImageList = this.iconList;
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView2_ItemSelectionChanged);
            this.listView2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseDoubleClick);
            // 
            // filePathTextBox2
            // 
            this.filePathTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filePathTextBox2.Location = new System.Drawing.Point(634, 13);
            this.filePathTextBox2.Name = "filePathTextBox2";
            this.filePathTextBox2.Size = new System.Drawing.Size(583, 22);
            this.filePathTextBox2.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видалитиToolStripMenuItem,
            this.скопіюватиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.редагуватиToolStripMenuItem,
            this.списокТегівToolStripMenuItem,
            this.створитиToolStripMenuItem,
            this.перейменуватиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 172);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // видалитиToolStripMenuItem
            // 
            this.видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            this.видалитиToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.видалитиToolStripMenuItem.Text = "Видалити";
            this.видалитиToolStripMenuItem.Click += new System.EventHandler(this.ВидалитиToolStripMenuItem_Click);
            // 
            // скопіюватиToolStripMenuItem
            // 
            this.скопіюватиToolStripMenuItem.Name = "скопіюватиToolStripMenuItem";
            this.скопіюватиToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.скопіюватиToolStripMenuItem.Text = "Скопіювати";
            this.скопіюватиToolStripMenuItem.Click += new System.EventHandler(this.СкопіюватиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.ВставитиToolStripMenuItem_Click);
            // 
            // редагуватиToolStripMenuItem
            // 
            this.редагуватиToolStripMenuItem.Name = "редагуватиToolStripMenuItem";
            this.редагуватиToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.редагуватиToolStripMenuItem.Text = "Редагувати";
            this.редагуватиToolStripMenuItem.Click += new System.EventHandler(this.РедагуватиToolStripMenuItem_Click);
            // 
            // списокТегівToolStripMenuItem
            // 
            this.списокТегівToolStripMenuItem.Name = "списокТегівToolStripMenuItem";
            this.списокТегівToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.списокТегівToolStripMenuItem.Text = "Редактор HTML";
            this.списокТегівToolStripMenuItem.Click += new System.EventHandler(this.СписокТегівToolStripMenuItem_Click);
            // 
            // створитиToolStripMenuItem
            // 
            this.створитиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.папкуToolStripMenuItem,
            this.файлtxtToolStripMenuItem});
            this.створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            this.створитиToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.створитиToolStripMenuItem.Text = "Створити";
            // 
            // папкуToolStripMenuItem
            // 
            this.папкуToolStripMenuItem.Name = "папкуToolStripMenuItem";
            this.папкуToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.папкуToolStripMenuItem.Text = "Папку";
            this.папкуToolStripMenuItem.Click += new System.EventHandler(this.ПапкуToolStripMenuItem_Click);
            // 
            // файлtxtToolStripMenuItem
            // 
            this.файлtxtToolStripMenuItem.Name = "файлtxtToolStripMenuItem";
            this.файлtxtToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.файлtxtToolStripMenuItem.Text = "Файл .txt";
            this.файлtxtToolStripMenuItem.Click += new System.EventHandler(this.ФайлtxtToolStripMenuItem_Click);
            // 
            // перейменуватиToolStripMenuItem
            // 
            this.перейменуватиToolStripMenuItem.Name = "перейменуватиToolStripMenuItem";
            this.перейменуватиToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.перейменуватиToolStripMenuItem.Text = "Перейменувати";
            this.перейменуватиToolStripMenuItem.Click += new System.EventHandler(this.ПерейменуватиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 651);
            this.Controls.Add(this.filePathTextBox2);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.filePathTextBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.backButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList iconList;
        private System.Windows.Forms.TextBox filePathTextBox1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox filePathTextBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem видалитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редагуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокТегівToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem створитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem папкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem файлtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перейменуватиToolStripMenuItem;
    }
}

