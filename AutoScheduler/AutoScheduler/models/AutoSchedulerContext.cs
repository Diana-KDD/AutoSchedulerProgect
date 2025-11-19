using AutoScheduler.models.Configuration;
using AutoScheduler.models.MiddleEntities;
using AutoScheduler.models.modelsConfiguration;
using AutoScheduler.models.Referenses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models
{
    public class AutoSchedulerContext: DbContext
    {
        DbSet<Discipline> Disciplines { get; set; } = null!;
        DbSet<StudentGroup> StudentGroups { get; set; } = null!;
        DbSet<AudienceSpecialization> AudienceSpecializations { get; set; } = null!;
        DbSet<Auditory> Auditories { get; set; } = null!;
        DbSet<Teacher> Teachers { get; set; } = null!;
        DbSet<Lesson> Lessons { get; set; } = null!;
        DbSet<DisciplineStudentGroup> DisciplineStudentGroups { get; set; } = null!;
        DbSet<DisciplineTeacher> DisciplineTeachers { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E3GTFG3;Initial Catalog=Dz_1;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new StudentGroupConfiguration());
            modelBuilder.ApplyConfiguration(new AudienceSpecializationConfiguration());
            modelBuilder.ApplyConfiguration(new AuditoryConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineStudentGroupConfiguration());
            modelBuilder.ApplyConfiguration(new DisciplineTeacherConfiguration());
        }
    }
}
