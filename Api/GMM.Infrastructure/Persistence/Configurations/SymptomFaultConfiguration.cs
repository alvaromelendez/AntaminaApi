using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMM.Domain.Entities;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class SymptomFaultConfiguration : IEntityTypeConfiguration<SymptomFault>
    {
        public void Configure(EntityTypeBuilder<SymptomFault> builder)
        {
            builder.ToTable("SymptomFault", "dbo");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Code)
                .HasColumnType("VACHAR(25)")
                .IsRequired();

            builder.Property(t => t.Key)
                .HasColumnType("VACHAR(25)")
                .IsRequired();

            builder.Property(t => t.Description)
                .HasColumnType("VACHAR(250)")
                .IsRequired();
        }
    }
}
