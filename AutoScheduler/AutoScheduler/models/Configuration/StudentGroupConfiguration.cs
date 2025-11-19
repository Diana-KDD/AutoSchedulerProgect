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
    public class StudentGroupConfiguration : IEntityTypeConfiguration<StudentGroup>
    {
        public void Configure(EntityTypeBuilder<StudentGroup> builder)
        {
            builder.HasKey(sg => sg.id);
            builder.HasIndex(sg=>sg.title).IsUnique();
            builder.Property(sg => sg.title).HasMaxLength(20);
            builder.Property(sg => sg.title).IsRequired();
            builder.HasAlternateKey(sg => sg.title);
            builder.Property(sg => sg.NumberStudents).IsRequired();
        }
    }
}
