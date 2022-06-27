using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class ClientMap : IEntityTypeConfiguration<ClientEntity>
    {
        public void Configure(EntityTypeBuilder<ClientEntity> builder)
        {
            builder.ToTable("Client");

            builder.HasKey(u => u.Id);

            builder.HasIndex(u => u.CNPJ)
                      .IsUnique();

            builder.Property(u => u.Name)
                      .IsRequired()
                      .HasMaxLength(60);

            builder.HasOne(u => u.Group)
                .WithMany(p => p.Clients)
                .HasForeignKey(p => p.GroupId);

        }
    }
}
