using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileManager
{
    class FindAvailableName
    {
        public string FileName(string path)
        {
            int k = 0;
            while (true)
            {
                if (File.Exists(path + "/" + "NewFile" + k.ToString() + ".txt"))
                {
                    k++;
                }
                else
                {
                    break;
                }
            }
            return "NewFile" + k.ToString() + ".txt";
        }
        public string DirectoryName(string path)
        {
            int k = 0;
            while (true)
            {
                if (Directory.Exists(path + "/" + "NewDirectory" + k.ToString()))
                {
                    k++;
                }
                else
                {
                    break;
                }
            }
            return "NewDirectory" + k.ToString();
        }
    }
}
