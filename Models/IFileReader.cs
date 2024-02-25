namespace FixedWidthParser.Models
{
    public interface IFileReader
    {
        IEnumerable<string> ReadLines();

    }
}