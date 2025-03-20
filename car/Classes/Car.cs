using car.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car.Classes
{
    public class Car : IVehiculo
    {
        public int amount { get; set; }
        public Car(int amount)
        {
            this.amount = amount;
        }
        public void Drive()
        {
            Console.WriteLine("The Car Is Driving");
        }
        public bool Refuel(int amount)
        {
            amount = amount + 1;
            return true;
        }
    }
}
