namespace FixedWidthParser.Models
{
    public class TextFileProvider : IFileProvider
    {
        public string Path { get; }
        public TextFileProvider(string path)
        {
            this.Path = path;      
        }     
        
        public IFileReader Reader => new DefaultFileReader(Path);
    }
}