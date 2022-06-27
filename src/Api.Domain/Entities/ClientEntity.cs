using System;

namespace Api.Domain.Entities
{
    public class ClientEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public DateTime FundationDate { get; set; }
        public Guid? GroupId { get; set; }
        public virtual GroupEntity Group { get; set; }
    }
}
