using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.Referenses
{
    public class AudienceSpecialization
    {
        public int id { get; set; }
        public string title { get; set; } = null!;

        public ICollection<Auditory> Auditories { get; set; } = new List<Auditory>();
    }
}
