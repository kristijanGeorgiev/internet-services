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
            Console.WriteLine(SortDigitsDescending(3581));
        }

        static int SortDigitsDescending(int num)
        {
            return int.Parse(new string(num.ToString().OrderByDescending(c => c).ToArray()));
        }
    }
}
