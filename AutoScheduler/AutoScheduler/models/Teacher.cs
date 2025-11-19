using AutoScheduler.models.MiddleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models
{
    public class Teacher
    {
        public int id { get; set; }

        public string first_name { get; set; } = null!;
        public string last_name { get; set; } = null!;
        public string middle_name { get; set; } = null!;

        public string specialization { get; set; } = null!;
        public string qualification { get; set; } = null!;

        public int workload { get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public ICollection<DisciplineTeacher> DisciplineTeachers { get; set; } = new List<DisciplineTeacher>();
    }
}
