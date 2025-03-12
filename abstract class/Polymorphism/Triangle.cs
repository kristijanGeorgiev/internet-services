using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Polymorphism
{
    class Triangle
    {
        public int Base { get; set; }
        public int height { get; set; }
        public Triangle(int Base, int height)
        {
            this.Base = Base;
            this.height = height;
        }
        public double CalculateArea()
        {
            return 0.5 * Base * height;
        }
    }
}
