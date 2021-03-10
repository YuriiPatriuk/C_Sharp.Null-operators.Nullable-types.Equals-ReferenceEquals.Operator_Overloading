using System;
using System.Collections;

namespace Equals_vs_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            //int value = 12; //stack
            //object obj = value; //heap    boxing
            //int result = (int)obj;// unboxing
            //Console.WriteLine(obj + " " + result);

            //ArrayList arr = new ArrayList();
            //arr.Add("Hello");
            //arr.Add(12);

            int[] arrA = { 10, 2, 34 }; //ref1 
            int[] arrB = { 10, 2, 34 };//ref2
            int[] arrC = arrA; // ref1
            Console.WriteLine($"Ref arrA == arrB - {object.ReferenceEquals(arrA,arrB)}");
            Console.WriteLine($"Ref arrA == arrC - {object.ReferenceEquals(arrA,arrC)}");

            double value1 = 23.45; //value types
            double value2 = 23.45; //value types
            Console.WriteLine($"Ref value1 == value2 - {object.ReferenceEquals(value1,value2)}");




        }
    }
}
