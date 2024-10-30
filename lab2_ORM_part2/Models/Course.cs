using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_ORM_part2.Models
{
    partial class Course
    {
        public long Id { get; set; }
        public string CourseName { get; set; }

        public long StudentId { get; set; }
        public Student Student { get; set; }

        public long TeacherId { get; set; }
        public Teacher Teacher { get; set; }

    }
}
