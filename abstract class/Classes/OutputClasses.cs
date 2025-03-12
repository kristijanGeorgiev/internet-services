using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Classes
{
    class OutputClasses
    {
        public string myString;
        public void PrintString()
        {
            Console.WriteLine(myString);
        }
        public void StaticPrinter()
        {
            Console.WriteLine("Static Printer Method");
        }
        public void StaticPrinter(string textToPrint)
        {
            Console.WriteLine("Static Printer overloaded 1" + textToPrint);
        }
        public void StaticPrinter(string textToPrint1, string textToPrint2)
        {
            Console.WriteLine("Static Printer overloaded  2 " + textToPrint1);
        }
    }
}
