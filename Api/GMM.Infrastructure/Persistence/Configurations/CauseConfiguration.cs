using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class CauseConfiguration : IEntityTypeConfiguration<Cause>
    {
        public void Configure(EntityTypeBuilder<Cause> builder)
        {
            builder.ToTable("Cause", "dbo");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Code)
                .HasColumnType("VACHAR(25)")
                .IsRequired();

            builder.Property(t => t.Key)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(t => t.Description)
                .HasColumnType("VACHAR(250)")
                .IsRequired();
        }
    }
}
