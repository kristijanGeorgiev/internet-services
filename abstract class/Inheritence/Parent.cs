using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Inheritence
{
    class Parent
    {
        public string parentString { get; set; }
        public Parent(string parentString)
        {
            this.parentString = parentString;
        }
        public void print()
        {
            Console.WriteLine("Parent Class");
        }
    }
}
