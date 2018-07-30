using Microsoft.AspNetCore.Mvc;
using NordeaFormatter;

namespace Web.Controllers.Api
{
    public class ApiController : Controller
    {
        private Formatter _formatter;
        public ApiController(Formatter formatter)
        {
            _formatter = formatter;
        }

        [HttpPost("api/format")]
        public ActionResult Format([FromBody]FormatRequest request)
        {
            if(request == null)
            {
                return Content("Invalid Input parameters.");
            }

            if(string.IsNullOrWhiteSpace(request.InputText))
            {
                return Content("Input your text.");
            }
            
            var splittedSentences = _formatter.Format(request.InputText);
            var genericFormatter = new GenericFormatter();
            var formatter = genericFormatter.Create((FormatType)request.FormatType);
            return Content(formatter.Format(splittedSentences));
        }
    }
}