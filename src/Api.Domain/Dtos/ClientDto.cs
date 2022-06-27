using Domain.Dtos;
using System;

namespace Api.Domain.Dtos
{
    public class ClientDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime FundationDate { get; set; }
        public GroupDto Group { get; set; }
    }
}
