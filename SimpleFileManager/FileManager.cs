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
namespace SimpleFileManager
{
    class FileManager
    {
        private void AddItem(string fileExtension, string name, ListView listView)
        {
            switch (fileExtension)
            {
                case ".MP3":
                case ".MP2":
                    listView.Items.Add(name, 5);
                    break;
                case ".EXE":
                case ".COM":
                    listView.Items.Add(name, 7);
                    break;

                case ".MP4":
                case ".AVI":
                case ".MKV":
                    listView.Items.Add(name, 6);
                    break;
                case ".PDF":
                    listView.Items.Add(name, 4);
                    break;
                case ".DOC":
                case ".DOCX":
                    listView.Items.Add(name, 3);
                    break;
                case ".PNG":
                case ".JPG":
                case ".JPEG":
                    listView.Items.Add(name, 9);
                    break;
                case ".TXT":
                    listView.Items.Add(name, 11);
                    break;
                default:
                    listView.Items.Add(name, 8);
                    break;
            }
        }
        public string RemoveBackSlash(string path)
        {
            if (path.LastIndexOf("/") == path.Length - 1 && path != "C:/")
            {
                path = path.Substring(0, path.Length - 1);
            }
            if (path == "C:")
                return "C:/";
            return path;
        }
        public string GoBack(ListView listView, string temp)
        {
            try
            {
                string path = RemoveBackSlash(temp);
                path = path.Substring(0, path.LastIndexOf("/"));
                path = RemoveBackSlash(path);
                return path;
            }
            catch (Exception)
            {
                return temp;
            }
        }
        public string loadButtonAction(string path, ListView listView, bool isFile, string name)
        {
            path = RemoveBackSlash(path);
            LoadFiles(path, listView, isFile, name);
            return path;
        }
        public void LoadFiles(string filePath, ListView listView, bool isFile, string currentlySelectedItemName)
        {
            DirectoryInfo fileList;
            string tempFilePath;
            FileAttributes fileAttr;
            if (isFile)
            {
                tempFilePath = filePath + "/" + currentlySelectedItemName;
                FileInfo fileDetails = new FileInfo(tempFilePath);
                fileAttr = File.GetAttributes(tempFilePath);
                Process.Start(tempFilePath);
            }
            else
            {
                fileAttr = File.GetAttributes(filePath);

            }

            if ((fileAttr & FileAttributes.Directory) == FileAttributes.Directory)
            {
                fileList = new DirectoryInfo(filePath);
                FileInfo[] files = fileList.GetFiles(); // GET ALL THE FILES
                DirectoryInfo[] dirs = fileList.GetDirectories(); // GET ALL THE DIRS
                string fileExtension = "";
                listView.Items.Clear();

                for (int i = 0; i < files.Length; i++)
                {
                    fileExtension = files[i].Extension.ToUpper();
                    AddItem(fileExtension, files[i].Name, listView);

                }

                for (int i = 0; i < dirs.Length; i++)
                {
                    listView.Items.Add(dirs[i].Name, 10);
                }


            }
        }
    }
}
