// See https://aka.ms/new-console-template for more information
using Polymorphism.Polymorphism;
Shape circle = new Circle(6.3);
Shape rectangle = new Rectangle(4.2, 8.6);
Console.WriteLine($" Circle Area is {circle.CalculateArea()}");
Console.WriteLine($" Circle Perimeter is {circle.CalculatePerimeter()}");
Console.WriteLine($" Rectangle Area ia {rectangle.CalculateArea()}");
Console.WriteLine($" Rectangle Perimeter is {circle.CalculatePerimeter()}");