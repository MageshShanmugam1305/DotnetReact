using FixedWidthParser.Models.RecordTypes;

namespace FixedWidthParser.Models.Specifications
{
    public class HolderSpecification : Ispecification<HolderRecord>
    {
        public HolderRecord record {get; set;}
        public Func<HolderRecord, bool> condition { get; set; }

        public HolderSpecification(HolderRecord record , Func<HolderRecord, bool> condition)
        {
            this.record = record;
            this.condition = condition;
        }

        public bool Eval()
        {
            return condition(record);
        }
    }
}
