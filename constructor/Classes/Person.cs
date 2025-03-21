using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor.Classes
{
    class Person
    {
        public string Name { get; set; }
        public Person(string Name)
        {
            this.Name = Name;
        }
        public Person()
        {
            Name = string.Empty;
        }
        public string ToString()
        {
            return Name;
        }
    }
}
