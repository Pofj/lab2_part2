using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_ORM_part2.Models
{
    partial class Student : Person
    {
        public long StudentId { get; set; }
        public string PhoneMum { get; set; }
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
