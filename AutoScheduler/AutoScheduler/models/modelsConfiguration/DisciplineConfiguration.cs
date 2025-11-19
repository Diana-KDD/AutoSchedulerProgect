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
    public class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder.HasKey(d => d.id);
            builder.HasIndex(d => d.title).IsUnique();
            builder.Property(d => d.title).HasMaxLength(50);
            builder.Property(d => d.title).IsRequired();
            builder.HasAlternateKey(d=>d.title);
            builder.Property(d => d.QuantityHours).IsRequired();
        }
    }
}
