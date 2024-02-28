using FixedWidthParser.Models;
using FixedWidthParser.Models.RecordFormat;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace FixedWidthParser.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileParserController : ControllerBase
    {
        private readonly ILogger<FileParserController> logger;
        private IErrorTrace errorTrace;
        private RecordFormat recordFormat;

        public FileParserController(ILogger<FileParserController> logger, IErrorTrace errorTrace, RecordFormat format )
        {
            this.logger = logger;
            this.errorTrace = errorTrace;
            this.recordFormat = format;
        }
        [HttpGet]
        public IActionResult ParseFile(string file)
        {
            try
            {
                IFileProvider fileProvider = new FileProviderFactory(file).GetProvider();
                bool isValid = new FileParser(fileProvider, errorTrace).Parse(); 
                return Ok(new {isValid = isValid});
            }
            catch (Exception ex) 
            {
                return ex switch
                {
                    FileNotFoundException => BadRequest(ex.Message),                    
                    _ => StatusCode(500, ex.Message)
                };
            }
        }
    }
}
