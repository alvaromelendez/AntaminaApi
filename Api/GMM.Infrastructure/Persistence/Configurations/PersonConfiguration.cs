﻿using GMM.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GMM.Infrastructure.Persistence.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person", "Demo");
            builder.HasKey(t => t.IdPerson); 
            //builder.Property(t => t.IdPerson)
            //    .UseIdentityColumn();

        }
    }
}
