using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2.Classes
{
    class Mathematics : Subject
    {
        public override void study()
        {
            base.study();
            Console.WriteLine("Study Mathematics");
        }
    }
}
