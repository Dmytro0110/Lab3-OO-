using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Fraction : Pair
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override Pair Add(Pair other)
        {
            if (other is Fraction fraction)
            {
                return new Fraction(this.numerator * fraction.denominator + fraction.numerator * this.denominator,
                                    this.denominator * fraction.denominator);
            }
            throw new ArgumentException("Недійсний тип для додавання!!!");
        }

        public override Pair Subtract(Pair other)
        {
            if (other is Fraction fraction)
            {
                return new Fraction(this.numerator * fraction.denominator - fraction.numerator * this.denominator,
                                    this.denominator * fraction.denominator);
            }
            throw new ArgumentException("Недійсний тип для віднімання!!!");
        }

        public override Pair Multiply(Pair other)
        {
            if (other is Fraction fraction)
            {
                return new Fraction(this.numerator * fraction.numerator, this.denominator * fraction.denominator);
            }
            throw new ArgumentException("Недійсний тип для множення!!!");
        }

        public override Pair Divide(Pair other)
        {
            if (other is Fraction fraction && fraction.numerator != 0)
            {
                return new Fraction(this.numerator * fraction.denominator, this.denominator * fraction.numerator);
            }
            throw new ArgumentException("Недійсний тип для ділення / ділиш на нуль!!!");
        }

        public override void Print()
        {
            Console.WriteLine($"Fraction: {numerator}/{denominator}");
        }
    }
}
