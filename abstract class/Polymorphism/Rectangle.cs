using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Polymorphism
{
    class Rectangle
    {
        public int length { get; set; }
        public int width { get; set; }
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }
        public double CalculateArea()
        {
            return length * width;
        }
    }
}
