using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Classes
{
    class Cuboid : Shape
    {
        public Cuboid()
        {
            Console.WriteLine("Enter length: ");
            Console.ReadLine();
            Console.WriteLine("Enter width: ");
            Console.ReadLine();
            Console.WriteLine("Enter height: ");
            Console.ReadLine();
        }
    }
}
