using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoScheduler.models
{
    public class StudentGroup
    {
        public int id { get; set; }
        public string title { get; set; } = null!;
        public int NumberStudents { get; set; }
    }
}
