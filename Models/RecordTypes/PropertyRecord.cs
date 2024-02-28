namespace FixedWidthParser.Models.RecordTypes
{
    public class PropertyRecord : RecordBase, IValidator
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
