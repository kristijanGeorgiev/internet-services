using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    internal class Reverse
    {
        static void Main()
        {
            Console.Write("Enter a string to reverse: ");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);

            Console.WriteLine("Reversed string: " + reversed);
        }

        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
