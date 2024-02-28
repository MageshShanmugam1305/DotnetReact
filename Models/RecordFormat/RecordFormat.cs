using System.Reflection;

namespace FixedWidthParser.Models.RecordFormat
{
    public class RecordFormat
    {
        public RecordFormat()
        {
            Holder = new List<Metadata>();
        }
       public List<Metadata> Holder { get; set; } 
    }
}
