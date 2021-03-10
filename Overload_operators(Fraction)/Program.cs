using System;

namespace Overload_operators_Fraction_
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr = new Fraction(1, 2);
            Console.WriteLine(fr);

            Fraction fr2 = new Fraction(1, 2);
            Console.WriteLine(fr2);

            Console.WriteLine(fr.Equals(fr2));
            //Console.WriteLine(fr.GetHashCode());
            //Console.WriteLine(fr.GetHashCode());

            Console.WriteLine(fr + fr2);
            Console.WriteLine(fr == fr2);
            Console.WriteLine(++fr);
        }
    }
}
