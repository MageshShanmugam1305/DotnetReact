namespace FixedWidthParser.Models.RecordTypes
{
    public class PropAddRecord : RecordBase, IRecord
    {
        public PropAddRecord(string line, int rowIdx, IErrorTrace errorTrace) : base(line, rowIdx, errorTrace)
        {

        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
