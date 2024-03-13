﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    abstract class Pair
    {
        public abstract Pair Add(Pair other);
        public abstract Pair Subtract(Pair other);
        public abstract Pair Multiply(Pair other);
        public abstract Pair Divide(Pair other);

        public virtual void Print()
        {
            Console.WriteLine("Pair");
        }
    }
}
