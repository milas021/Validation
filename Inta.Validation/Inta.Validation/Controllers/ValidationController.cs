using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inta.Validation.Command;

namespace Inta.Validation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        [HttpPost("submit-request")]
        public async Task<string> SubmitRequest(SubmitRequestCommand command)
        {
            var xx = "hello";
            return xx;
        }
    }
}
