namespace FixedWidthParser.Models
{
    public class ErrorRecord
    {
        public int RowIdx { get; set; }
        public int ColumnIdx { get; set; } 

        public string ErrorMsg { get; set; } = string.Empty;
    }
}
