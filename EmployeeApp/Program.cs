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
int CountEmployeesWithAmount(List<Employee> Employees, int Amount)
{
    return Employees.Count(s => s.Amount == Amount);
}
int minAmount = GetMinAmount(Employees);
int maxAmount = GetMaxAmount(Employees);

int minAmountCount = CountEmployeesWithAmount(Employees, minAmount);
int maxAmountCount = CountEmployeesWithAmount(Employees, maxAmount);

Console.WriteLine($"Maximum Employee Amount: {maxAmount}");
if (minAmountCount > 1)
{
    Console.WriteLine($"Number of Employees Amountd {minAmount}: {minAmountCount}");
}

Console.WriteLine($"Minimum Employee Amount: {minAmount}");
if (maxAmountCount > 1)
{
    Console.WriteLine($"Number of Employees Amountd {maxAmount}: {maxAmountCount}");
}