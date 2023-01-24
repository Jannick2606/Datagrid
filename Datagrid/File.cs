namespace Datagrid
{
    public class File
    {
        private string name;
        private string path;
        private string type;
        private long size;
        private string base64Data;
        public string Name { get { return name; } set { name = value; } }    
        public string Path { get { return path; } set { path = value; } }
        public string Type { get { return type; } set { type = value; } }
        public long Size { get { return size; } set { size = value; } }
        public string Base64Data { get { return base64Data; } set { base64Data = value; } }

        public File(string name, string path, string type, long size, string base64Data)
        {
            Name = name;
            Path = path;
            Type = type;
            Size = size;
            Base64Data = base64Data;
        }
    }
}
