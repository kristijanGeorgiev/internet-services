using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Polymorphism
{
    class Vehicle
    {
        public double distance { get; set; }
        public double hour { get; set; }
        public double fuel { get; set; }
        public Vehicle(double distance, double hour, double fuel)
        {
            this.distance = distance;
            this.hour = hour;
            this.fuel = fuel;
        }
        public double Average()
        {
            return distance / fuel;
        }
    }
}
