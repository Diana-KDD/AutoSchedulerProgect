using AutoScheduler.models.MiddleEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.Configuration
{
    public class DisciplineStudentGroupConfiguration : IEntityTypeConfiguration<DisciplineStudentGroup>
    {
        public void Configure(EntityTypeBuilder<DisciplineStudentGroup> builder)
        {
            builder.HasKey(dsg => new {dsg.StudentGroupId, dsg.DisciplineId});

            builder.HasOne(dsg => dsg.StudentGroup)
                   .WithMany(sg => sg.DisciplineStudentGroups)
                   .HasForeignKey(dsg => dsg.StudentGroupId);

            builder.HasOne(dsg => dsg.Discipline)
                   .WithMany(d => d.DisciplineStudentGroups)
                   .HasForeignKey(dsg => dsg.DisciplineId);

            
        }
    }
}
