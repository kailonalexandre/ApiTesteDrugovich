using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class GroupMap : IEntityTypeConfiguration<GroupEntity>
    {
        public void Configure(EntityTypeBuilder<GroupEntity> builder)
        {
            builder.ToTable("Group");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                      .IsRequired()
                      .HasMaxLength(60);
        }
    }
}
