using System;

namespace Domain.Dtos
{
    public class GroupInsertDto
    {
        public DateTime CreateAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Name { get; set; }
    }
}
