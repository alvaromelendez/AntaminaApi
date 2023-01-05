using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class JobPositionConfiguration : IEntityTypeConfiguration<JobPosition>
    {
        public void Configure(EntityTypeBuilder<JobPosition> builder)
        {
            builder.ToTable("JobPosition", "dbo");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Code)
                .HasColumnType("VACHAR(100)")
                .IsRequired();

            builder.Property(t => t.Description)
                .HasColumnType("VACHAR(250)")
                .IsRequired();

            builder.Property(t => t.Responsible)
               .HasColumnType("VACHAR(100)")
               .IsRequired();

            builder.Property(t => t.Center)
               .HasColumnType("INT")
               .IsRequired();

            builder.Property(t => t.PlanificationGroup)
               .HasColumnType("VACHAR(50)");
        }
    }
}
