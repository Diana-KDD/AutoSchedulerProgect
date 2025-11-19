using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models
{
    public class Lesson
    {
        public int id {  get; set; }
        public Teacher Teacher { get; set; } = null!;
        public int TeacherId {  get; set; }
        public StudentGroup StudentGroup { get; set; } = null!;
        public int StudentGroupId {  get; set; }
        public Discipline Discipline { get; set; } = null!;
        public int DisciplineId {  get; set; }
        public Auditory Auditory { get; set; } = null!;
        public int AuditoryId { get; set; }

        public DateTime DateTime { get; set; }
    }
}
