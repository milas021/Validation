using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Inta.Validation.Command;
using Inta.Validation.Model;
using Microsoft.EntityFrameworkCore;

namespace Inta.Validation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValidationController : ControllerBase
    {
        private readonly DatabaseContext _db;

        public ValidationController(DatabaseContext db)
        {
            _db = db;
        }

        [HttpPost("submit-request")]
        public async Task<IActionResult> SubmitRequest(SubmitRequestCommand command)
        {
            var request = new Request()
            {
                CompanyCode = command.CompanyCode,
                CompanyCountry = command.CompanyCountry,
                CompanyName = command.CompanyName,
                CustomerId = command.CustomerId,
                Description = command.Description,
                Id = Guid.NewGuid(),
                RequestType = command.RequestType
            };
           await _db.Requests.AddAsync(request);
            await _db.SaveChangesAsync();

            return Ok();
        }

        public async Task<IActionResult> ShowRequest(Guid customerId)
        {
            var requests =await _db.Requests.Where(x => x.CustomerId == customerId).ToListAsync();
            return Ok(requests);
        }
    }
}
