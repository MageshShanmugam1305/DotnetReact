using FixedWidthParser.Models.RecordTypes;

namespace FixedWidthParser.Models.Specifications
{
    public interface ISpecificationConfig<T> where T: IValidator
    {
        List<Ispecification<T>> specifications { get; set; }

        void Setup();
    }
}
