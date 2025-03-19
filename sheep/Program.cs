class Program
{
    static void Main()
    {
        Console.WriteLine("Start inserting sheep presence (true/false/none):");
        string[] inputs = Console.ReadLine().Split(',');
        bool?[] sheepPresence = new bool?[inputs.Length];
        for(int i = 0; i<inputs.Length; i++)
        {
            sheepPresence[i] = ParseSheepPresence(inputs[i].Trim());
        }
        CountSheep(sheepPresence);
    }
    static bool? ParseSheepPresence(string input)
    {
        if(bool.TryParse(input, out bool result))
        {
            return result;
        }
        return null;
    }
    static void CountSheep(bool?[] sheep)
    {
        int present = 0, absent = 0, unknown = 0;
        foreach(var s in sheep)
        {
            if (s == true)
                present++;
            else if (s == false)
                absent++;
            else
                unknown++;
        }
        Console.WriteLine($"{present} sheep are present");
        Console.WriteLine($"{absent} sheep are absent");
        Console.WriteLine($"{unknown} sheep are unknown");
    }
}