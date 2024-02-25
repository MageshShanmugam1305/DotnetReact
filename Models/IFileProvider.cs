namespace FixedWidthParser.Models
{
    public interface IFileProvider
    {       
        string Path { get; }

        IFileReader Reader { get; }
    }
}
