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
    public class DisciplineTeacherConfiguration : IEntityTypeConfiguration<DisciplineTeacher>
    {
        public void Configure(EntityTypeBuilder<DisciplineTeacher> builder)
        {
            builder.HasKey(dt => new { dt.TeacherId, dt.DisciplineId });

            builder.HasOne(dt => dt.Teacher)
                   .WithMany(sg => sg.DisciplineTeachers)
                   .HasForeignKey(dt => dt.TeacherId);

            builder.HasOne(dt => dt.Discipline)
                   .WithMany(d => d.DisciplineTeachers)
                   .HasForeignKey(dt => dt.DisciplineId);
        }
    }
}
