using System;

namespace Api.Domain.Dtos
{
    public class ClientInsertDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime FundationDate { get; set; }
        public Guid GroupId { get; set; }
    }
}
