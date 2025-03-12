using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Polymorphism
{
    class Circle
    {
        public double r { get; set; }
        public Circle(double r)
        {
            this.r = r;
        }
        public double CalculateArea()
        {
            return 3.14 * r * r;
        }
    }
}
