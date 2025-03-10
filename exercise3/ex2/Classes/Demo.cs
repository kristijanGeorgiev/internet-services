using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Classes
{
    class Demo
    {
        public int Sum(int x, int y)
        {
            int value = x + y;
            return value;
        }
        public int Sum(int x, int y, int z)
        {
            int value = x + y + z;
            return value;
        }
        public void Details(string name, int id)
        {
            Console.WriteLine(" Name " + name + " Id " + id);
        }
        public void Details(int id, string name)
        {
            Console.WriteLine(" Name " + name + " Id " + id);
        }
    }
}
