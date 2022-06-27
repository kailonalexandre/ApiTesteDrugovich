
using System.Collections.Generic;

namespace Api.Domain.Entities
{
    public class GroupEntity : BaseEntity
    {
        public string Name { get; set; }
        public virtual List<ClientEntity> Clients { get; set; }
    }
}
