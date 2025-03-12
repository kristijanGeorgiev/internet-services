using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_animal.Classes
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public Animal(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public abstract void Eat();
    }
}
