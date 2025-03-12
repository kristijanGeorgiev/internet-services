﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class.Abstraction
{
    public abstract class Square : AreaClass
    {
        private readonly int side = 0;
        public Square(int n)
        {
            side=n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
}
