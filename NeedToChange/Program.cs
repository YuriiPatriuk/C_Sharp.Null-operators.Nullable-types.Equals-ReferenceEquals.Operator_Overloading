using System;
using System.Collections.Generic;

namespace Null_Operation
{
    class Person
    {
        public Person(string name)
        {
            Name = name;
        }
        private string name;
        public string Name
        {
            get => name;
            set => name = value ?? "NoName";
        }
        public override string ToString()
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            string str = null; 

            //?? null-COLEASING
            Console.WriteLine(str ?? "Empty string"); // str!=nullptr ? str: "Empty string" 

            Person person = new Person(null);
            Console.WriteLine(person.Name);

            //?. null-CONDITIONAL - if object == null, so method is not called( return null)   
            Console.WriteLine($"Try Remove: {str?.Remove(0, 4)?? "Bad string"}");

            int[] arr = null;//{ 10, 12, 100, 345 };
            Console.WriteLine($"Length: {arr?.Length ?? -1}");
            Console.WriteLine($"arr[0] = {arr?[0]}");

            arr ??= new int[10];
            Console.WriteLine($"Length: {arr?.Length ?? -1}");



        }
    }
}
