namespace FixedWidthParser.Models.RecordTypes
{
    public class PropertyRecord : RecordBase, IRecord
    {
        public PropertyRecord(string line, int rowIdx, IErrorTrace errorTrace) : base(line, rowIdx, errorTrace)
        {
        }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
