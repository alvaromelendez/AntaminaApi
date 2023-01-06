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
    public class FaultConfiguration : IEntityTypeConfiguration<Fault>
    {
        public void Configure(EntityTypeBuilder<Fault> builder)
        {
            builder.ToTable("Fault", "dbo");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.ObjectPart)
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
