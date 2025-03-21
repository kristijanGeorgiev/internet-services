class Program
{
    static void Main()
    {
        Console.WriteLine("Start inserting students");
        try
        {
            string[] inputs = Console.ReadLine().Split(',');
            if(inputs.Length > 8)
            {
                Console.WriteLine("Error. Maximum Number of Students in a group is 8");
                return;
            }
            int[] ages = inputs.Select(input => int.Parse(input.Trim())).ToArray();
            FindYoungestAndOldest(ages);
        }
        catch(FormatException)
        {
            Console.WriteLine(" Invalid input. Enter only numbers");
        }
        catch(Exception ex)
        {
            Console.WriteLine($" An Unexpected Error occured: {ex.Message}");
        }
    }
    static void FindYoungestAndOldest(int[] ages)
    {
        int minAge = ages.Min();
        int maxAge = ages.Max();
        int minCount = ages.Count(age => age == minAge);
        int maxCount = ages.Count(age => age == maxAge);
        if(minCount > 1)
        {
            Console.WriteLine($" There are {minCount} students in that age");
        }
        else
        {
            Console.WriteLine();
        }
        Console.WriteLine($" Oldest Student in the group is {minAge} years old");
        if(maxCount > 1)
        {
            Console.WriteLine($" There are {maxCount} students in that age");
        }
        else
        {
            Console.WriteLine();
        }
        Console.WriteLine($" Youngest Student in the group is {maxAge} years old");
    }
}