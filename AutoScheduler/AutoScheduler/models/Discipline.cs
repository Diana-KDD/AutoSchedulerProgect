using AutoScheduler.models.MiddleEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models
{
    public class Discipline
    {
        public int id {  get; set; }
        public string title { get; set; } = null!;
        public int quantityHours {  get; set; }

        public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
        public ICollection<DisciplineStudentGroup> DisciplineStudentGroups { get; set; } = new List<DisciplineStudentGroup>();
        public ICollection<DisciplineTeacher> DisciplineTeachers { get; set; } = new List<DisciplineTeacher>();
    }
}
