using AutoScheduler.models.modelsConfiguration;
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
        DbSet<AudienceSpecialization> AudienceSpecializations { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("?");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new DisciplineConfiguration());
            modelBuilder.ApplyConfiguration(new StudentGroupConfiguration());
            modelBuilder.ApplyConfiguration(new AudienceSpecializationConfiguration());
        }
    }
}
