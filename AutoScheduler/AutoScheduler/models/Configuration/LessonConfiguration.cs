using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.Configuration
{
    public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
    {
        public void Configure(EntityTypeBuilder<Lesson> builder)
        {
            builder.HasKey(l => l.id);

            builder.HasOne(l => l.Teacher)
                   .WithMany(t => t.Lessons)
                   .HasForeignKey(l => l.TeacherId);

            builder.HasOne(l => l.StudentGroup)
                   .WithMany(sg => sg.Lessons)
                   .HasForeignKey(l => l.StudentGroupId);

            builder.HasOne(l => l.Discipline)
                   .WithMany(d => d.Lessons)
                   .HasForeignKey(l => l.DisciplineId);

            builder.HasOne(l => l.Auditory)
                   .WithMany(a => a.Lessons)
                   .HasForeignKey(l => l.AuditoryId);

            builder.HasIndex(l => new {l.TeacherId, l.StudentGroupId, l.DisciplineId, l.AuditoryId, l.DateTime}).IsUnique();
        }
    }
}
