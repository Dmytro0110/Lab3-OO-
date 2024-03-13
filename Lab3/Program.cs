using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pair pair1 = new Fazzynumber(3.5);
            Pair pair2 = new Fazzynumber(2.8);
            Pair result = pair1.Add(pair2);
            result.Print();

            pair1 = new Fraction(1, 4);
            pair2 = new Fraction(1, 2);
            result = pair1.Add(pair2);
            result.Print();
        }
    }
}
