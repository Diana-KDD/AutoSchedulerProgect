using AutoScheduler.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.modelsConfiguration
{
    public class AudienceSpecializationConfiguration : IEntityTypeConfiguration<AudienceSpecialization>
    {
        public void Configure(EntityTypeBuilder<AudienceSpecialization> builder)
        {
            builder.HasKey(aus => aus.id);
            builder.Property(aus => aus.title).HasMaxLength(20);
            builder.HasAlternateKey(aus => aus.title);
        }
    }
}
