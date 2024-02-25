using FixedWidthParser.Models.RecordTypes;

namespace FixedWidthParser.Models.Specifications
{
    public class HolderRecordSpecConfig : ISpecificationConfig<HolderRecord>
    {
        public HolderRecordSpecConfig(HolderRecord record, IErrorTrace errorTrace)
        {
            specifications = new List<Ispecification<HolderRecord>>();
            this.record = record;
            this.errorTrace = errorTrace;
        }
        public List<Ispecification<HolderRecord>> specifications { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private HolderRecord record;
        private IErrorTrace errorTrace;

        public void Setup()
        {
            //Tax-Id Mandatory
            specifications.Add(new HolderSpecification(record, record => !string.IsNullOrWhiteSpace(record.Holder_TaxId)));
            //Tax-Id Numeric
            specifications.Add(new HolderSpecification(record, record => long.TryParse(record.Holder_TaxId, out long _)));
        }
    }
}
