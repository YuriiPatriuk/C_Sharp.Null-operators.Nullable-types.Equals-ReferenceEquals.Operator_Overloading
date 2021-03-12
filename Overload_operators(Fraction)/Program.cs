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

            Fraction fr3 = new Fraction(15, 2);
            double a = (double)fr3;
            Console.WriteLine(a);
            try
            {
                fr3[0] = 100;
                fr3[1] = 3;
                Console.WriteLine(fr3); //moment implicit operator double!!!!! 33.(3)
                Console.WriteLine(fr3.ToString()); 
                Console.WriteLine(fr3["num"]); 
                fr3[1] = 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
