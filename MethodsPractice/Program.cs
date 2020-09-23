using System;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = GetUserName();
            WelcomeUser(name);
            Console.ReadLine();
        }
        private static void SayName()
        {
            Console.WriteLine("Malcome Baggett");
        }

        private static void WelcomeUser(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        private static string GetUserName()
        {
            System.Console.WriteLine("Please enter your name:");
            string output = Console.ReadLine();
            return output;
        }
    }
}
