#region No Exception Handling
Console.WriteLine("Enter an integer number");
var num = int.Parse(Console.ReadLine());
Console.WriteLine($"Square of {num} is {num * num}");
#endregion
#region Exception Handling
try
{
    Console.WriteLine("Enter an integer number");
    var num1 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Square of {num1} is {num1 * num1}");
}
catch
{
    Console.WriteLine("Error Occured!");
}
finally
{
    Console.WriteLine("Re-try with a different number");
}
#endregion
#region Catch with parameters
try
{
    Console.WriteLine("Enter a int number");
    var num2 = int.Parse(Console.ReadLine());
    Console.WriteLine($"Square of {num2} is {num2 * num2}");
}
catch
{
    Console.WriteLine("Error info ");
}
finally
{
    Console.WriteLine("Re-try with a different number");
}
#endregion
#region Exception Filters
Console.WriteLine("Enter a number");
try
{
    int num3 = int.Parse(Console.ReadLine());
    int result = 100 / num3;
    Console.WriteLine("100 / {0} = {1} ", num3, result);
}
catch(DivideByZeroException ex)
{
    Console.WriteLine("Cannot divide by zero: "+ ex.Message);
}
catch(FormatException ex)
{
    Console.WriteLine("Not valid format: " + ex.Message);
}
catch
{
    Console.WriteLine("Error Occured: ");
}
#endregion
#region Invalid catch
try
{

}
catch
{
    Console.WriteLine("Error Occured: ");
}
#endregion
#region Method Division
Division(25, 5);
Division(25, 0);
void Division(int v1, int v2)
{
    int result = 0;
    try
    {
        result = v1 / v2;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Exception caught: " + ex.Message);
    }
    finally
    {
        Console.WriteLine("Result: {0} ", result);
    }
}
#endregion
#region Nested Try-Catch Blocks
var divider = 0;
try
{
    try
    {

        var result = 100 / divider;
    }
    catch
    {
        Console.WriteLine("Inner Catch");
    }

}
catch
{
    Console.WriteLine("Outer catch: ");
}
#endregion
#region Nested Try-Catch 2
var divider1 = 0;
try
{
    try
    {

        var result = 100 / divider1;
    }
    catch(NullReferenceException ex)
    {
        Console.WriteLine("Inner Catch ");
    }

}
catch
{
    Console.WriteLine("Outer catch ");
}
#endregion