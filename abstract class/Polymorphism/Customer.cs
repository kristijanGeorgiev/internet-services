using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Polymorphism
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {

        }
        public Customer(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public override string ToString()
        {
            return $"Customer Id {Id} Customer Name {Name}";
        }
    }
}
