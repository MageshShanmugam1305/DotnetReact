namespace FixedWidthParser.Models
{
    public interface IErrorTrace
    {
        List<ErrorRecord> Errors { get; set;} 
        
        void AddError(ErrorRecord error);   
    }
}
