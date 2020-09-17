using System;

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
            string[] firstName = new string[5];
            firstName[0] = "Fiona";
            firstName[1] = "Fionne";
            firstName[2] = "Malcome";
            firstName[3] = "Wunsa";
            firstName[4] = "Mick";

            string namesString = "Tojo,Mary,Tommy,Carlos,Svenva";
            string[] names = namesString.Split(",");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
            for (var i = 0; i <= firstName.Length - 1; i++)
            {
                Console.WriteLine(firstName[i]);
            }
            Console.WriteLine();
            int[] numbers = new int[10];

            for (var i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = i;
            }
            Console.WriteLine($"Numbers Array filled currently has {numbers.Length} numbers in the array");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            {

            }
            Console.ReadLine();
        }
    }
}
