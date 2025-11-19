using AutoScheduler.models.Referenses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models
{
    public class Auditory
    {
        public int id { get; set; }
        public string title { get; set; } = null!;
        public int capacity { get; set; }

        public AudienceSpecialization AudienceSpecialization { get; set; } = null!;
        public int AudienceSpecializationId { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    }
}
