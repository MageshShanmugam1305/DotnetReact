using FixedWidthParser.Models.RecordTypes;

namespace FixedWidthParser.Models.Specifications
{
    public interface Ispecification<T> where T : IValidator 
    {
        HolderRecord record { get; set; }
        Func<HolderRecord, bool> condition { get; set; }
        bool Eval();
    }
}
