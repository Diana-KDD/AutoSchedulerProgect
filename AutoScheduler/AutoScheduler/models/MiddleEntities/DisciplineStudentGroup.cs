using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models.MiddleEntities
{
    public class DisciplineStudentGroup
    {
        public StudentGroup StudentGroup { get; set; } = null!;
        public int StudentGroupId {  get; set; }
        public Discipline Discipline { get; set; } = null!;
        public int DisciplineId {  get; set; }
    }
}
