using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace descending
{
    internal class Descending
    {
        static void Main()
        {
            Console.WriteLine(DescendingOrder(42145));
            Console.WriteLine(DescendingOrder(145263));
            Console.WriteLine(DescendingOrder(123456789));
        }

        static int DescendingOrder(int num)
        {
            return int.Parse(new string(num.ToString().OrderByDescending(c => c).ToArray()));
        }
    }
}
