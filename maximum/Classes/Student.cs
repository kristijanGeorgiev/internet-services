using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum.Classes
{
    class Student
    {
        public int points { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
        public Student(int points, string Name, int Id)
        {
            this.points = points;
            this.Name = Name;
            this.Id = Id;
        }
    }
}
