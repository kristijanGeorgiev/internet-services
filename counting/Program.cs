class Program
{
    static void Main()
    {
        Console.WriteLine("Start Inserting One Two and Three Digit Numbers");
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
        int onedigit = 0, twodigit = 0, threedigit = 0;
        foreach(var n in number)
        {
            if(n>=1 && n<=9)
            {
                onedigit = onedigit + 1;
            }
            else if(n>=10 && n<=99)
            {
                twodigit = twodigit + 1;
            }
            else
            {
                threedigit = threedigit + 1;
            }
        }
        Console.WriteLine($" One Digit Numbers {onedigit}");
        Console.WriteLine($" Two Digit Numbers {twodigit}");
        Console.WriteLine($" Three Digit Numbers {threedigit}");
    }
}