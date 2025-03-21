using StudentApp.Classes;

List<Student> students = new List<Student>
{
    new Student { Name = "Alice", Age = 14 },
    new Student { Name = "Bob", Age = 16 },
    new Student { Name = "Charlie", Age = 15 },
    new Student { Name = "Diana", Age = 14 },
    new Student { Name = "Ethan", Age = 17 },
    new Student { Name = "Fiona", Age = 16 },
    new Student { Name = "George", Age = 15 },
    new Student { Name = "Hannah", Age = 17 }
};
int GetMinAge(List<Student> students)
{
    return students.Min(s => s.Age);
}
int GetMaxAge(List<Student> students)
{
    return students.Max(s => s.Age);
}
int CountStudentsWithAge(List<Student> students, int age)
{
    return students.Count(s => s.Age == age);
}
int minAge = GetMinAge(students);
int maxAge = GetMaxAge(students);

int minAgeCount = CountStudentsWithAge(students, minAge);
int maxAgeCount = CountStudentsWithAge(students, maxAge);

Console.WriteLine($"Youngest student age: {minAge}");
if (minAgeCount > 1)
{
    Console.WriteLine($"Number of students aged {minAge}: {minAgeCount}");
}

Console.WriteLine($"Oldest student age: {maxAge}");
if (maxAgeCount > 1)
{
    Console.WriteLine($"Number of students aged {maxAge}: {maxAgeCount}");
}
