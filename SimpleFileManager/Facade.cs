using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFileManager
{
    class Facade
    {
        FileOperations op = new FileOperations();
        HTMLOperations hop = new HTMLOperations();
        public Facade()
        {
           
        }
        public void Delete(bool isFile, string path)
        {
            op.Delete(isFile, path);
        }
        public void Copy(bool isFile, string filePath, string fileName)
        {
            op.Copy(isFile, filePath, fileName);
        }
        public void Paste(bool isFile, string finalDestination)
        {
            op.Paste(isFile, finalDestination);
        }
        public void Edit() { }
        public void Create(bool isFile, string path)
        {
            op.Create(isFile, path);
        }
        public void Rename(bool isFile, string firstName, string lastName)
        {
            op.Rename(isFile, firstName, lastName);
        }
        public List<string> MakeTagList(string path)
        {
            return hop.TagList(path);
        }
        public void DeleteTag(string path, string tag)
        {
            hop.DeleteTag(path, tag);
        }
        public void ChangeTag(string path, string oldTag, string newTag)
        {
            hop.ChangeTag(path, oldTag, newTag);
        }
    }

}
