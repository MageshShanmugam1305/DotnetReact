namespace FixedWidthParser.Models
{
    public class DefaultFileReader : IFileReader
    {
        private readonly string _path;
        public DefaultFileReader(string path)
        {
           this._path = path;
        }
        public IEnumerable<string> ReadLines()
        {
            return File.ReadLines(_path);
        }
    }
}
