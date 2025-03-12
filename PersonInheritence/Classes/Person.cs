using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInheritence.Classes
{
    internal class Person
    {
        public string Name { get; set; }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public override string ToString()
        {
            return $" name of person {Name}";
        }
    }
}
