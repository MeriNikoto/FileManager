using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SimpleFileManager
{
    class FileOperations
    {
        string buffFile, buffDirectory;
        public FileOperations()
        {

        }
        public void Delete(bool isFile, string filePath)
        {
            if (isFile)
            {
                System.IO.File.Delete(filePath);
            }
            else
            {
                System.IO.Directory.Delete(filePath, true);
            }
        }
        public void Copy(bool isFile, string filePath, string fileName)
        {
            buffDirectory = filePath;
            buffFile = fileName;
        }
       
        public void Paste(bool isFile, string fileDestination)
        {
            if (isFile)
            {
                DirectoryInfo dir = new DirectoryInfo(buffDirectory);
                FileInfo[] files = dir.GetFiles();
                if (buffDirectory != null && buffFile != null && fileDestination != buffDirectory && !File.Exists(fileDestination + "/" + buffFile))
                {
                    System.IO.File.Copy(buffDirectory + "/" + buffFile, fileDestination + "/" + buffFile);
                }
                else
                    throw new IOException();
            }
            else
            {
                if(buffDirectory != null)
                {
                    if (fileDestination.Contains(buffFile))
                    {
                        throw new IOException();
                    }
                    DirectoryInfo dir = new DirectoryInfo(buffDirectory + "/" + buffFile);
                    if (!dir.Exists)
                    {
                        throw new DirectoryNotFoundException(
                            "Source directory does not exist or could not be found: "
                            + buffDirectory);
                    }

                    DirectoryInfo[] dirs = dir.GetDirectories();


                    Directory.CreateDirectory(fileDestination + "/"+ buffFile );

                    // Get the files in the directory and copy them to the new location.
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        string tempPath = Path.Combine(fileDestination + "/" + buffFile, file.Name);
                        file.CopyTo(tempPath, false);
                    }

                    // If copying subdirectories, copy them and their contents to new location.
                    foreach (DirectoryInfo subdir in dirs)
                    {
                            string tempPath = Path.Combine(fileDestination, subdir.Name);
                            buffDirectory = subdir.FullName;
                            Paste(false, tempPath);
                    }
                    
                }
            }
        }
        public void Create(bool isFile, string path)
        {
            FindAvailableName fan = new FindAvailableName();
            if (isFile)
            {
                
                string name = fan.FileName(path);
                FileStream fs = File.Create(path + "/" + name);
                fs.Close();
            }
            else
            {
                string name = fan.DirectoryName(path);
                Directory.CreateDirectory(path + "/" + name);
                Create(true, path + "/" + name);
            }
        }
        public void Rename(bool isFile, string firstName, string lastName)
        {
            if (isFile)
            {
                System.IO.File.Move(firstName, lastName);
                
            }
            else
            {
                if(firstName != lastName)
                    System.IO.Directory.Move(firstName, lastName);
               
            }
        }
        

    }
}
