using Inta.Validation.Enums;

namespace Inta.Validation.Model
{
    public class Request
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyCountry { get; set; }
        public string CompanyCode { get; set; }
        public string Description { get; set; }
        public RequestType RequestType { get; set; }
    }
}
