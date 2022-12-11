using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class ProccessConfigurationConfiguration : IEntityTypeConfiguration<GMM.Domain.Entities.ProccessConfiguration>
    {
        public void Configure(EntityTypeBuilder<GMM.Domain.Entities.ProccessConfiguration> builder)
        {
            builder.ToTable("ProccessConfiguration", "Cnfg");
            builder.HasKey(t => t.IdProccessConfiguration);

            builder.Property(t => t.EndPoint)
                .HasMaxLength(400)
                .IsUnicode(false);
        }
    }
}
