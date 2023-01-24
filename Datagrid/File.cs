namespace Datagrid
{
    public class File
    {
        private string name;
        private string path;
        private string type;
        private long size;
        private string base64Data;
        public string Name { get; set; }    
        public string Path { get; set; }          
        public string Type { get; set; }
        public long Size { get; set; }
        public string Base64Data { get; set; }
        
        public File(string name, string path, string type, long size, string base64Data)
        {
            this.name = name;
            this.path = path;
            this.type = type;
            this.size = size;
            this.base64Data = base64Data;
        }
    }
}
