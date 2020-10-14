using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericHelper<PersonModel> peopleHelper = new GenericHelper<PersonModel>();

            string result = FizzBuzz("string");
            Console.WriteLine(result);
            string res = PrintItem(101010);
            Console.WriteLine(res);
        }
        public static string PrintItem<T>(T item)
        {
            string output = item.ToString();
            return output;
        }
        public class PersonModel : IErrorCheck
        {
            public string FirstName { get; set; }
            public bool HasError { get; set; }
        }
        private static string FizzBuzz<T>(T item)
        {
            int itemLength = item.ToString().Length;
            string output = "";
            if (itemLength % 3 == 0)
            {
                output = "Fizz";
            }
            if (itemLength % 5 == 0)
            {
                output = "Buzz";
            }
            return output;
        }
        public class GenericHelper<T> where T : IErrorCheck
        {
            public List<T> Items { get; set; }
            public List<T> RejectedItems { get; set; }
            public void CheckItemAndAdd(T item)
            {
                if (item.HasError == false)
                {
                    Items.Add(item);
                }
                else
                {
                    RejectedItems.Add(item);
                }
            }
        }
        public class CarModel : IErrorCheck
        {
            public string Manufacturer { get; set; }
            public bool HasError { get; set; }
        }
        public interface IErrorCheck
        {
            bool HasError { get; set; }

        }
    }
}
