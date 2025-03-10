// See https://aka.ms/new-console-template for more information
using ex2.Classes;
class Program
{
    static void Main(string[] args)
    {
        try
        {
        Person person = new Person();
        person.name = "Davor";
        Console.WriteLine($"the name of the person is {person.name}");
        Employee employee = new Employee();
        employee.name = "Kristijan";
        employee.MiddleName = "David";
        employee.LastName = "Georgiev";
        employee.Age = 40;
        Console.WriteLine($"name {employee.name} middle name {employee.MiddleName} surname {employee.LastName} and age {employee.Age}");
        Cuboid cuboid = new Cuboid();
        cuboid.length = 100;
        cuboid.height = 210;
        cuboid.width = 145;
        Console.WriteLine($" length of cuboid {cuboid.length} height of cuboid {cuboid.height} width of cuboid {cuboid.width}");
        Cube cube = new Cube();
        cube.side = 5;
        Console.WriteLine($" Number of sides is {cube.side}");
        Mathematics mathematics = new Mathematics();
        mathematics.study();
        Demo demo = new Demo();
        int sum1 = demo.Sum(24, 28);
        Console.WriteLine(" sum of two " + "integer value: " + sum1);
        int sum2 = demo.Sum(10, 20, 30);
        Console.WriteLine(" sum of three " + "integer value: " + sum2);
        demo.Details("John", 1);
        demo.Details("Joe", 2);
        }
        catch(OutOfMemoryException)
        {
            Console.WriteLine("Out of Memory ");
        }
        catch(FormatException)
        {
            Console.WriteLine("Invalid Format ");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Invalid Information " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Everything is Ok");
        }
    }
}