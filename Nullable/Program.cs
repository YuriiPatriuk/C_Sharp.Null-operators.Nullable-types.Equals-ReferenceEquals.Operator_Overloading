using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nullable<ValueType> - full name of Nullable type
            string str = null;//!!!! EXISTS
            int? value = null;
            if (value.HasValue)
            {
                value *= 2;
                Console.WriteLine($"Value: {value}");
            }
            else
                Console.WriteLine($"Value is null");
            Console.WriteLine($"Value or default: {value.GetValueOrDefault()}");
            Console.WriteLine($"Value or default(1111): {value.GetValueOrDefault(1111)}");

            int? value2 = 500;
            //int sum = (value + value2).GetValueOrDefault(-32582734);
            int? sum = value + value2;
            Console.WriteLine("Sum = " + (sum ?? 0));


        }
    }
}
