// See https://aka.ms/new-console-template for more information
#region Hello World
Console.WriteLine("Hello World");
Console.ReadKey();
#endregion
#region Sum
int a, b;
a = 1234;
b = 99;
int c = a + b;
Console.WriteLine($" The sum is {c}");
#endregion
#region If Statement
if (Math.Sqrt(16) < 3)
    System.Console.WriteLine("the number is less than 3");
else
    System.Console.WriteLine("the number is greater than 3");
Console.ReadLine();
#endregion
#region For Loop
for (int i = 0; i< 5; i++)
{
    System.Console.WriteLine("{0}", i);
}
#endregion
