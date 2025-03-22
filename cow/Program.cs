class Program
{
    static void Main()
    {
        Console.WriteLine("Start inserting cow presence (true/false/none):");
        string[] inputs = Console.ReadLine().Split(',');
        bool?[] cowPresence = new bool?[inputs.Length];
        for (int i = 0; i < inputs.Length; i++)
        {
            cowPresence[i] = ParseCowPresence(inputs[i].Trim());
        }
        CountCow(cowPresence);
    }
    static bool? ParseCowPresence(string input)
    {
        if (bool.TryParse(input, out bool result))
        {
            return result;
        }
        return null;
    }
    static void CountCow(bool?[] cow)
    {
        int present = 0, absent = 0, unknown = 0;
        foreach (var s in cow)
        {
            if (s == true)
                present++;
            else if (s == false)
                absent++;
            else
                unknown++;
        }
        Console.WriteLine($"{present} cow is present");
        Console.WriteLine($"{absent} cow are absent");
        Console.WriteLine($"{unknown} cow are unknown");
    }
}