using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SimpleFileManager
{
    class HTMLOperations
    {
        public void ChangeTag(string path, string oldTag, string newTag)
        {
            List<string> oldFile = new List<string>();
            StreamReader fstream = new StreamReader(path);
            while (!fstream.EndOfStream)
            {
                string tmp = fstream.ReadLine();
                tmp =  tmp.Replace("<"+oldTag+">", "<"+newTag+">");
                tmp = tmp.Replace("<" +"/"+ oldTag + ">", "<"+ "/" + newTag + ">");
                tmp =  tmp.Replace("<>", "");
                tmp = tmp.Replace("</>", "");
                oldFile.Add(tmp);
            }
            fstream.Close();
            StreamWriter outstream = new StreamWriter(path, false);
            foreach (string line in oldFile)
            {
                outstream.WriteLine(line);
            }
            outstream.Close();
        }
        public List<string> TagList(string path)
        {
            StreamReader fstream = new StreamReader(path);
            List<string> res = new List<string>();
            while (!fstream.EndOfStream)
            {
                string tmp = fstream.ReadLine();
                int startIndex = 0;
                int index = tmp.IndexOf('<', startIndex);
                while (tmp.IndexOf('<', startIndex) != -1)
                {
                    index = tmp.IndexOf('<', startIndex);
                    string tag = "";
                    index++;
                    while (index < tmp.Length && tmp[index] != '>')
                    {
                        tag += tmp[index];
                        index++;
                    }
                    startIndex = index;
                    if (!res.Contains(tag) && tag[0] != '/')
                    {
                        res.Add(tag);
                    }

                }
            }
            fstream.Close();
            return res;
        }
        public void DeleteTag(string path, string deadTag)
        {
            ChangeTag(path, deadTag, "");
;        }
    }
}

