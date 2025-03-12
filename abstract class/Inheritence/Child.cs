using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Inheritence
{
    class Child : Parent
    {
        public Child() : base("Inherited")
        {
            Console.WriteLine("Child Constructor");
        }
        public void print()
        {
            Console.WriteLine("I Am Child Constructor");
        }
    }
}
