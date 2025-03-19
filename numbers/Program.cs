class Program
{
    static void Main()
    {
        Console.WriteLine("Start inserting numbers between 1 and 20");
        string[] inputs = Console.ReadLine().Split(',');
        int[]? numberPresence = new int[inputs.Length];
        for(int i = 1; i < inputs.Length; i++)
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
        int onedigit = 0, twodigit = 0;
        foreach(var n in number)
        {
            if(n>=1 && n<=9)
            {
                onedigit = onedigit + 1;
            }
            else
            {
                twodigit = twodigit + 1;
            }
        }
        Console.WriteLine($" Number of One digit numbers is {onedigit}");
        Console.WriteLine($" Number of Two Digit Numbers is {twodigit}");
    }
}