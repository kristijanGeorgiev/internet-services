using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessor.Polymorphism
{
    class Person
    {
        public int age { get; set; }
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public void SetAge(int n)
        {
            age = n;
        }
    }
    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("I'm Studying");
        }
        public void ShowAge(int n)
        {
            Console.WriteLine($" My age is {n} years old");
        }
    }
    class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("I'm Explaining");
        }
    }
}