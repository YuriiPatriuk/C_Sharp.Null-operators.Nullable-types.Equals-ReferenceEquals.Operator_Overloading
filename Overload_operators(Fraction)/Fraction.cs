using System;
using System.Collections.Generic;
using System.Text;

namespace Overload_operators_Fraction_
{
    class Fraction
    {
        int num, denom;
        public int Denom
        {
            get => denom;
            set => denom = value != 0 ? value : throw new Exception("Wrong denominator!");
        }
        public int Num
        {
            get => num;
            set => num = value;
        }
        public Fraction(int num = 0, int denom = 1)
        {
            try
            {
                Denom = denom;
            }
            catch (Exception)
            {
                Denom = 1;
            }
            Num = num;
        }
        public static Fraction operator +(Fraction one, Fraction two)
        {
            return new Fraction(
                num: one.num * two.denom + one.denom * two.num,
                denom: one.denom * two.denom
                ) ;
        }

        public static bool operator ==(Fraction one, Fraction two)
        {
            if (ReferenceEquals(one, two))
                return true;
            //if (one == null) // recurse
            if(one is null)
                return false; 
            return one.Equals(two);
        }
        public static bool operator !=(Fraction one, Fraction two)
        {
            return !(one == two);
        }

        public override string ToString()
        {
            return $"{Num}/{Denom}";
        }
        public override bool Equals(object obj)
        {
            /* if (obj == null || obj is Fraction)
                 return false;
             Fraction fr = (Fraction)obj;
             return this.num * fr.denom == this.denom * fr.num;*/

            Fraction fr = obj as Fraction;
            if (fr == null)
                return false;
            return this.num * fr.denom == this.denom * fr.num;
        }
        public override int GetHashCode()
        {
            return ((decimal)this.num/ denom).GetHashCode();
        }

    }   
}
