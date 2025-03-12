using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Abstraction
{
    class AnotherInheritFromBase : Base
    {
        public virtual void BaseMethod()
        {
            Console.WriteLine("Class AnotherInheritFromBase");
        }
    }
}
