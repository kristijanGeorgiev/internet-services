class Program
{
    static void Main()
    {
        Console.WriteLine("Start Inserting Prime Numbers");
        string[] inputs = Console.ReadLine().Split(',');
        int[]? numberPresence = new int[inputs.Length];
        int counterprime = 0;
        int counternotprime = 0;
        for(int i = 0; i < inputs.Length; i++)
        {
            numberPresence[i] = ParseNumberPresence(inputs[i].Trim());
        }
        foreach(var n in numberPresence)
        {
            if(IsPrime(n))
            {
                counterprime = counterprime + 1;
            }
            else
            {
                counternotprime = counternotprime + 1;
            }
        }
        Console.WriteLine($" Prime Numbers {counterprime}");
        Console.WriteLine($" Not Prime Numbers {counternotprime}");
    }
    static int ParseNumberPresence(string input)
    {
        if(int.TryParse(input, out int result))
        {
            return result;
        }
        return 0;
    }

    static bool IsPrime(int n)
    {
        int i = 0;
        bool prime = true;
        for(i=2; i <= n-1; i++)
        {
            if(n%i==0)
            {
                prime = false;
            }
        }
        return prime;
    }
}