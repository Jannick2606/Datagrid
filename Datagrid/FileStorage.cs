namespace Datagrid
{
    public class FileStorage
    {
        private List<File> files = new List<File>();
        public void AddFile(File file)
        {
            files.Add(file);
        }

        //Unused method that I wanted to implement if I had time
        public void RemoveFile(File userFile)
        {
            foreach (File file in files)
            {
                if (userFile.Equals(file)) { files.Remove(file); }
            }
        }

        public void ChangeName(File file, string newName)
        {
            file.Name = newName;
        }

        public List<File> GetFiles()
        {
            return files;
        }

    }
}
