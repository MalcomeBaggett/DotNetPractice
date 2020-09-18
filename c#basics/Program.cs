using System;
using System.Collections.Generic;

namespace c_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do and While Loops
            // Do loops run atleast once
            // int tries = 0;
            // int problemsSolved = 0;
            // do
            // {
            //     Console.WriteLine($"on try {tries}");
            //     tries += 1;
            // } while (tries < 10);

            // While loops do not run unless condition is met
            // while (problemsSolved < 11)
            // {
            //     Console.WriteLine($"You currently have solved {problemsSolved} problems");
            //     problemsSolved += 1;
            // }
            //     string result = "";
            //     string firstName;
            //     do
            //     {
            //         Console.WriteLine("What is your first name user?");
            //         firstName = Console.ReadLine();
            //         Console.WriteLine($"Hello user {firstName}, do you wish to continue? Enter yes or no.");
            //         result = Console.ReadLine();
            //     } while (result.ToLower() == "yes");
            //     Console.ReadLine();

            // Arrays
            // string[] firstName = new string[5];
            // firstName[0] = "Fiona";
            // firstName[1] = "Fionne";
            // firstName[2] = "Malcome";
            // firstName[3] = "Wunsa";
            // firstName[4] = "Mick";

            // instantiate an array and fill it
            // string[] lastNames = new string[] { "Gau", "Long", "Chiang" };

            // string namesString = "Tojo,Mary,Tommy,Carlos,Svenva";
            // string[] names = namesString.Split(",");
            // foreach (var name in names)
            // {
            //     Console.WriteLine(name);
            // }
            // Console.WriteLine();
            // for (var i = 0; i <= firstName.Length - 1; i++)
            // {
            //     Console.WriteLine(firstName[i]);
            // }
            // Console.WriteLine();
            // int[] numbers = new int[10];

            // for (var i = 0; i <= numbers.Length - 1; i++)
            // {
            //     numbers[i] = i;
            // }
            // Console.WriteLine($"Numbers Array filled currently has {numbers.Length} numbers in the array");
            // foreach (var item in numbers)
            // {
            //     Console.WriteLine(item);
            // }
            // {

            // }
            // Console.ReadLine();

            // string names = "Trey,Malcome,Wunsa,FIona";
            // string[] namesArray = names.Split(',');
            // Console.WriteLine($"Choose and number from 0 to {namesArray.Length - 1}, and I will tell you a name");
            // string index = Console.ReadLine();
            // bool validIndex = int.TryParse(index, out int ind);
            // Console.WriteLine(namesArray[ind]);
            // Console.ReadLine();

            // Lists

            // List<string> firstNames = new List<string>();
            // int num = 100;
            // for (var i = 0; i < num; i++)
            // {
            //     firstNames.Add($"{i}");
            // }
            // Console.WriteLine(firstNames.Count);
            // // removes element at index
            // firstNames.RemoveAt(1);
            // // removes by value
            // firstNames.Remove("2");
            // Console.WriteLine(firstNames.Count);

            // Dictionary
            // Dictionary<int, int> numbers = new Dictionary<int, int>();
            Dictionary<int, string> importantYears = new Dictionary<int, string>();
            importantYears[1990] = "I was born";
            importantYears[1982] = "Fiona was born";
            importantYears[2020] = "Fionne was born";
        }
    }
}
