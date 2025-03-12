using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Polymorphism
{
    class Shape
    {
        public virtual double CalculateArea()
        {
            return 0.0;
        }
    }
    class Circle: Shape
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
    class Rectangle: Shape
    {
        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
}
