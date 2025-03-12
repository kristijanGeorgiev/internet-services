using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Polymorphism
{
    class Shape
    {
        public int length { get; set; }
        public int radius { get; set; }
        public int width { get; set; }
        public Shape(int length, int radius)
        {
            this.length = length;
            this.radius = radius;
        }
        public Shape(int width)
        {
            this.width = width;
        }
        public virtual void Area()
        {
            double area = 0;
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine(area);
        }
    }
}
