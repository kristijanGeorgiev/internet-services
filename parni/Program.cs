class Program
{
    static void Main()
    {
        Console.WriteLine("Start inserting even and odd numbers");
        string[] inputs = Console.ReadLine().Split(',');
        int[]? numberPresence = new int[inputs.Length];
        for(int i = 0; i < inputs.Length; i++)
        {
            numberPresence[i] = ParseNumberPresence(inputs[i].Trim());
        }
        CountNumbers(numberPresence);
    }
    static int ParseNumberPresence(string input)
    {
        if(int.TryParse(input, out int result))
        {
            return result;
        }
        return 0;
    }
    static void CountNumbers(int[] number)
    {
        int even = 0, odd = 0;
        foreach(var n in number)
        {
            if (n % 2 == 0)
            {
                even = even + 1;
            }
            else
            {
                odd = odd + 1;
            }
        }
        Console.WriteLine($" Even numbers {even}");
        Console.WriteLine($" Odd numbers {odd}");
    }
}