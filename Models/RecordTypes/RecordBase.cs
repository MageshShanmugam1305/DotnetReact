namespace FixedWidthParser.Models.RecordTypes
{
    public abstract class RecordBase
    {
        protected string _line;
        private int _recordLength = 625;
        protected int _rowIdx;
        protected IErrorTrace errorTrace;
        public RecordBase(string line, int rowIdx, IErrorTrace errorTrace)
        {
            this._line = line;
            this._rowIdx = rowIdx;
            this.errorTrace = errorTrace;
        }
        public virtual bool ValidateRecord()
        {
            if(this._line == null || this._line.Length != _recordLength)
            {
                return false;
            }
            errorTrace.AddError(new ErrorRecord
            {
                RowIdx = _rowIdx,
                ColumnIdx = -1,
                ErrorMsg = ErrorConstants.RECORDLENGTHERROR
            });
            return true;
        }


    }
}
