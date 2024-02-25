using FixedWidthParser.Models.RecordTypes;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FixedWidthParser.Models
{
    internal class FileParser
    {
        private IFileProvider fileProvider;
        private IErrorTrace errorTrace;

        public FileParser(IFileProvider fileProvider, IErrorTrace errorTrace)
        {
            this.fileProvider = fileProvider;
            this.errorTrace = errorTrace;
        }

        public bool Parse()
        {
            bool isValid = false;
            var reader = fileProvider.Reader;
            int rowIdx = 0;
            foreach(var line in reader.ReadLines()) 
            {
                char TR_Code = line[0];
                rowIdx++;
                isValid = TR_Code switch
                {
                    '1' =>  new HolderRecord(line, rowIdx, errorTrace).Validate(),
                    '2' =>  new PropertyRecord(line, rowIdx, errorTrace).Validate(),
                    '3' =>  new PropAddRecord(line, rowIdx, errorTrace).Validate(),
                    '5' =>  new SecurityRecord(line, rowIdx, errorTrace).Validate(),
                    '6' =>  new TangibleRecord(line, rowIdx, errorTrace).Validate(),
                    '9' =>  new SumInfoRecord(line, rowIdx, errorTrace).Validate(),
                     _  =>  false
                };
                if (!isValid) break;
            }
            return isValid;
        }
    }
}