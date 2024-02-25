namespace FixedWidthParser.Models
{
    public class CSVFileProvider : IFileProvider
    {
        public CSVFileProvider(string path)
        {
            this.Path = path;
        }
        public string Path { get; }

        public IFileReader Reader => throw new NotImplementedException();
    }
}