using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.ToTable("Activity", "dbo");
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
