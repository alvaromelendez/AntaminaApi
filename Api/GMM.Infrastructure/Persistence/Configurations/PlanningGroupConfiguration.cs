using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class PlanningGroupConfiguration : IEntityTypeConfiguration<PlanningGroup>
    {
        public void Configure(EntityTypeBuilder<PlanningGroup> builder)
        {
            builder.ToTable("PlanningGroup", "dbo");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Code)
                .HasColumnType("VACHAR(100)")
                .IsRequired();

            builder.Property(t => t.Description)
                .HasColumnType("VACHAR(250)")
                .IsRequired();

            builder.Property(t => t.Center)
               .HasColumnType("INT")
               .IsRequired();
        }
    }
}
