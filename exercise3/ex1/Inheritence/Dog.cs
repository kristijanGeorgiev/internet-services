using ex1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1.Inheritence
{
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Enter ID: ");
            Console.ReadLine();
            Console.WriteLine("Enter Name: ");
            Console.ReadLine();
        }
    }
}
