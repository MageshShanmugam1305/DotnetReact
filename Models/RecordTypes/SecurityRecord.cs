namespace FixedWidthParser.Models.RecordTypes
{
    public class SecurityRecord : RecordBase, IRecord
    {
        public SecurityRecord(string line, int rowIdx, IErrorTrace errorTrace) : base(line, rowIdx, errorTrace)
        {
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
