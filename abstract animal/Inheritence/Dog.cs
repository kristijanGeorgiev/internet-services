using abstract_animal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_animal.Inheritence
{
    public class Dog : Animal
    {
        public Dog(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public override void Eat()
        {
            Console.WriteLine($"The Dog {Name} is Eating");
        }
    }
}
