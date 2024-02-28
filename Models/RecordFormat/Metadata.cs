namespace FixedWidthParser.Models.RecordFormat
{
    public class Metadata
    {
        public String FieldName { get; set; }
        public int Length { get; set; }
        public int Start { get; set; }
        public int End { get; set; }
        public string Type { get; set; }
        public string MRO { get; set; }
        public string AcceptValues { get; set; } = "";
        public bool IsRange { get; set; } = false;

    }
}