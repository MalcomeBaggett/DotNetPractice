using System;
using System.Collections.Generic;

namespace MiniProjOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem One
            // Dictionary<int, string> EmployeeIdDict = new Dictionary<int, string>();
            // string employeeID;
            // EmployeeIdDict[1] = "Malcome Baggett";
            // EmployeeIdDict[2] = "Fiona Baggett";
            // Console.WriteLine("Welcome to GreenBox Farm's Employee Look Up");
            // Console.WriteLine("Please Enter an Employee ID to lookup");
            // employeeID = Console.ReadLine();
            // bool validatedID = int.TryParse(employeeID, out int validID);

            // if (validatedID == true)
            // {
            //     if (EmployeeIdDict.ContainsKey(validID))
            //     {
            //         Console.WriteLine(EmployeeIdDict[validID]);
            //     }
            // }

            // Console.ReadLine();

            // Problem Two
            string userName = GetUserName();
            WelcomeUser(userName);

        }
        private static void WelcomeUser(string name)
        {
            Console.WriteLine($"Welcome {name}");
        }

        private static string GetUserName()
        {
            Console.WriteLine($"Please enter your username:");
            string name = Console.ReadLine();

            return name;
        }
    }
}
