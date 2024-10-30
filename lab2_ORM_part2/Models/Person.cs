using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_ORM_part2.Models
{
    partial class Person
    {
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Otchestvo { get; set; }

        public string SeriyaPass { get; set; } = null!;

        public string NomerPass { get; set; } = null!;


    }
}
