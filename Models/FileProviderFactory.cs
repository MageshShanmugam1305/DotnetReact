namespace FixedWidthParser.Models
{
    public class FileProviderFactory
    {
        private readonly string _path;
        private FileInfo _info { get; }
        public FileProviderFactory(string path) 
        { 
            this._path = path;
            this._info = new FileInfo(path);
        }
        
        public  IFileProvider GetProvider()
        {
            if(_info.Exists) throw new FileNotFoundException();
            return _info.Extension switch
            {
                "txt" => new TextFileProvider(_path),
                "csv" => new CSVFileProvider(_path),
                _ => throw new InvalidOperationException("Please provide CSV or text file")
            };
        }
    }
}
