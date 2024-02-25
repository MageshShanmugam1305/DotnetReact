namespace FixedWidthParser.Models.RecordTypes
{
    public class SumInfoRecord : RecordBase, IRecord
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
