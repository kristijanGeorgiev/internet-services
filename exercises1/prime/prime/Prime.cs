using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    internal class Prime
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (IsPrime(number))
                    Console.WriteLine($"{number} is a prime number.");
                else
                    Console.WriteLine($"{number} is not a prime number.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            for (int i = 3; i * i <= num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
