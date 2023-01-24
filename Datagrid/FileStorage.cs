using Microsoft.AspNetCore.Components.Forms;

namespace Datagrid
{
    public class FileStorage
    {
        private List<File> files = new List<File>();
        public List<File> Files { get; private set; }
        public void AddFile(File file)
        {
            files.Add(file);
        }
        public void RemoveFile(File userFile)
        {
            foreach (File file in files)
            {
                if (userFile.Equals(file)) { files.Remove(file); }
            }
        }
        public List<File> GetFiles()
        {
            return files;
        }

    }
}
