using EmployeeApp.Classes;

List<Employee> Employees = new List<Employee>
{
    new Employee { Name = "Alice", Amount = 1000 },
    new Employee { Name = "Bob", Amount = 1600 },
    new Employee { Name = "Charlie", Amount = 1300 },
    new Employee { Name = "Diana", Amount = 1400 },
    new Employee { Name = "Ethan", Amount = 1700 },
    new Employee { Name = "Fiona", Amount = 1600 },
    new Employee { Name = "George", Amount = 1500 },
    new Employee { Name = "Hannah", Amount = 1800 }
};
int GetMinAmount(List<Employee> Employees)
{
    return Employees.Min(s => s.Amount);
}
int GetMaxAmount(List<Employee> Employees)
{
    return Employees.Max(s => s.Amount);
}
int GetAverageAmount(List<Employee> Employees)
{
    return (int)Employees.Average(s => s.Amount);
}
int GetSumAmount(List<Employee> Employees)
{
    return Employees.Sum(s => s.Amount);
}
int CountEmployeesWithAmount(List<Employee> Employees, int Amount)
{
    return Employees.Count(s => s.Amount == Amount);
}
int minAmount = GetMinAmount(Employees);
int maxAmount = GetMaxAmount(Employees);
int averageAmount = GetAverageAmount(Employees);
int sumAmount = GetSumAmount(Employees);
int minAmountCount = CountEmployeesWithAmount(Employees, minAmount);
int maxAmountCount = CountEmployeesWithAmount(Employees, maxAmount);
int averageAmountCount = CountEmployeesWithAmount(Employees, averageAmount);
int sumAmountCount = CountEmployeesWithAmount(Employees, sumAmount);
Console.WriteLine($"Maximum Employee Amount: {maxAmount}");
if (minAmountCount > 1)
{
    Console.WriteLine($"Number of Employees Amount {minAmount}: {minAmountCount}");
}

Console.WriteLine($"Minimum Employee Amount: {minAmount}");
if (maxAmountCount > 1)
{
    Console.WriteLine($"Number of Employees Amount {maxAmount}: {maxAmountCount}");
}
Console.WriteLine($" Sum Employee Amount: {sumAmount}");
if (sumAmountCount > 1)
{
    Console.WriteLine($"Number of Employees Amount {sumAmount}: {sumAmountCount}");
}
Console.WriteLine($" Average Employee Amount: {averageAmount}");
if (averageAmountCount > 1)
{
    Console.WriteLine($"Number of Employees Amount {minAmount}: {minAmountCount}");
}