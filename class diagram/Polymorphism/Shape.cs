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
        public virtual double CalculatePerimeter()
        {
            return 0.0;
        }
    }
    class Circle : Shape
    {
        public double radius { get; set; }
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
        public override double CalculatePerimeter()
        {
            return 2 * 3.14 * radius;
        }
    }
    class Rectangle : Shape
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double CalculateArea()
        {
            return side1 * side2;
        }
        public override double CalculatePerimeter()
        {
            return 2 * side1 + 2 * side2;
        }
    }
}
