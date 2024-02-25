using FixedWidthParser.Models.RecordTypes;

namespace FixedWidthParser.Models.Specifications
{
    public interface Ispecification<T> where T : IRecord 
    {
        HolderRecord record { get; set; }
        Func<HolderRecord, bool> condition { get; set; }
        bool Eval();
    }
}
