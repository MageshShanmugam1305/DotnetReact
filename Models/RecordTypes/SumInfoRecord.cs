namespace FixedWidthParser.Models.RecordTypes
{
    public class SumInfoRecord : RecordBase, IValidator
    {
        public SumInfoRecord(string line, int rowIdx, IErrorTrace errorTrace) : base(line, rowIdx, errorTrace)
        {

        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
