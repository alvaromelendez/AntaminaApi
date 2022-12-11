using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class ProccessConfiguration : IEntityTypeConfiguration<Proccess>
    {
        public void Configure(EntityTypeBuilder<Proccess> builder)
        {
            builder.ToTable("Proccess", "Cnfg");
            builder.HasKey(t => t.IdProccess);

            builder.Property(t => t.Name)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(t => t.Description)
                .HasMaxLength(500)
                .IsUnicode(false);
        }
    }
}
