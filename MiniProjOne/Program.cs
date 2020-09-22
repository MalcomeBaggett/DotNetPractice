using System;
using System.Collections.Generic;

namespace MiniProjOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> EmployeeIdDict = new Dictionary<int, string>();
            string employeeID;
            EmployeeIdDict[1] = "Malcome Baggett";
            EmployeeIdDict[2] = "Fiona Baggett";
            Console.WriteLine("Welcome to GreenBox Farm's Employee Look Up");
            Console.WriteLine("Please Enter an Employee ID to lookup");
            employeeID = Console.ReadLine();
            bool validatedID = int.TryParse(employeeID, out int validID);

            if (validatedID == true)
            {
                if (EmployeeIdDict.ContainsKey(validID))
                {
                    Console.WriteLine(EmployeeIdDict[validID]);
                }
            }

            Console.ReadLine();
        }
    }
}
