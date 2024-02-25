namespace FixedWidthParser.Models
{
    public class ErrorTrace : IErrorTrace
    {
        public List<ErrorRecord> Errors { get; set; }   

        public ErrorTrace() {
           Errors = new List<ErrorRecord>();
        }

        public void AddError(ErrorRecord error)
        {
            Errors.Add(error);
        }
    }
}
