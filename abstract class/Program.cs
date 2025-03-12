// See https://aka.ms/new-console-template for more information
#region Classes
using abstract_class.Abstraction;
using abstract_class.Classes;
using abstract_class.Inheritence;
using abstract_class.Polymorphism;
OutputClasses outputclasses = new OutputClasses();
outputclasses.PrintString();
outputclasses.StaticPrinter();
outputclasses.StaticPrinter(" First Overload");
outputclasses.StaticPrinter(" Second overload text 1 ", "second overload text 2");
#endregion
#region Abstraction
Base baseclass;
baseclass = new InheritFromBase();
baseclass.BaseMethod();
baseclass = new AnotherInheritFromBase();
baseclass.BaseMethod();
#endregion
#region Inheritence
Child child = new Child();
child.print();
#endregion
#region Polymorphism
Triangle triangle = new Triangle(4, 9);
Console.WriteLine($"Area of triangle is " + triangle.CalculateArea());
Rectangle rectangle = new Rectangle(6, 8);
Console.WriteLine($"Area of rectangle is " + rectangle.CalculateArea());
Circle circle = new Circle(9.4);
Console.WriteLine($"Area of circle is " + circle.CalculateArea());
Vehicle vehicle = new Vehicle(3.2, 9.4, 5.7);
Console.WriteLine($"Average of vehicle is " + vehicle.Average());
Customer customer = new Customer(1, "Kristijan");
Console.WriteLine(customer.ToString());
#endregion