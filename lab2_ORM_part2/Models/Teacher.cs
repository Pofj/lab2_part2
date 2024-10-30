using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_ORM_part2.Models
{
    partial class Teacher : Person
    {
        public long TeacherId { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
