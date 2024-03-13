using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Fazzynumber : Pair
    {
        private double value;

        public Fazzynumber(double value)
        {
            this.value = value;
        }

        public override Pair Add(Pair other)
        {
            if (other is Fazzynumber fazzynumber)
            {
                return new Fazzynumber(this.value + fazzynumber.value);
            }
            throw new ArgumentException("Недійсний тип для додавання!!!");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is Fazzynumber fazzynumber)
            {
                return new Fazzynumber(this.value - fazzynumber.value);
            }
            throw new ArgumentException("Недійсний тип для віднімання!!!");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is Fazzynumber fazzynumber)
            {
                return new Fazzynumber(this.value * fazzynumber.value);
            }
            throw new ArgumentException("Недійсний тип для множення!!!");
        }

        public override Pair Divide(Pair other)
        {
            if (other is Fazzynumber fazzynumber && fazzynumber.value != 0)
            {
                return new Fazzynumber(this.value / fazzynumber.value);
            }
            throw new ArgumentException("Недійсний тип для ділення / ділиш на нуль!!!");
        }

        public override void Print()
        {
            Console.WriteLine($"Fazzynumber: {value}");
        }
    }
}
