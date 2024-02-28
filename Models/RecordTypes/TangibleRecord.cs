namespace FixedWidthParser.Models.RecordTypes
{
    public class TangibleRecord : RecordBase, IValidator
    {
        public TangibleRecord(string line, int rowIdx, IErrorTrace errorTrace) : base(line, rowIdx, errorTrace)
        {
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
