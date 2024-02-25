using FixedWidthParser.Models.Specifications;

namespace FixedWidthParser.Models.RecordTypes
{
    public class HolderRecord : RecordBase, IRecord 
    {
        private HolderRecordSpecConfig config;
        public HolderRecord(string line, int rowIdx, IErrorTrace errorTrace): base(line, rowIdx, errorTrace) {
            this.config = new HolderRecordSpecConfig(this, errorTrace);
        }

        public string Holder_TaxId => _line.Substring(1, 9);

        public string Holder_TaxId_Ext => _line.Substring(10, 4);
        public bool Validate()
        {
           if(!base.ValidateRecord()) return false;
           config.Setup();
           bool isvalid = true;
           foreach(var spec in config.specifications) 
           { 
              isvalid = isvalid &&  spec.Eval();
           }
           return isvalid;           
        }
    }
}
