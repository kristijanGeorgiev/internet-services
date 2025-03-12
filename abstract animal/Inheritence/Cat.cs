using abstract_animal.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_animal.Inheritence
{
    public class Cat : Animal
    {
        public Cat(string Name) : base(Name)
        {
            this.Name = Name;
        }
        public override void Eat()
        {
            Console.WriteLine($"The Cat {Name} is Eating");
        }
    }
}
