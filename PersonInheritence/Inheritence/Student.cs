using PersonInheritence.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritence.Inheritence
{
    class Student : Person
    {
        public Student(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public void StudyMethod()
        {
            Console.WriteLine("Student is Studying");
        }
    }
    class Teacher : Person
    {
        public Teacher(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public void ExplainMethod()
        {
            Console.WriteLine("Teacher is Explaining");
        }
    }
}
