using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class NotificationClassConfiguration : IEntityTypeConfiguration<NotificationClass>
    {
        public void Configure(EntityTypeBuilder<NotificationClass> builder)
        {
            builder.ToTable("NotificationClass", "dbo");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Key)
                .HasColumnType("VACHAR(100)")
                .IsRequired();

            builder.Property(t => t.Description)
                .HasColumnType("VACHAR(250)")
                .IsRequired();
        }
    }
}
