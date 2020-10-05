using System;
using System.Collections.Generic;
namespace OOP1
{
    public class RequestData
    {
        public List<string> reqUserData()
        {
            List<string> userData = new List<string>();
            string firstName = "";
            string lastName = "";
            string email = "";

            Console.WriteLine("Welcome, please follow the prompts below.");
            Console.WriteLine("Please end your first name");
            firstName = Console.ReadLine();
            userData.Add(firstName);
            Console.WriteLine("Please enter your last name.");
            lastName = Console.ReadLine();
            userData.Add(lastName);
            Console.WriteLine("Pleast enter your email");
            email = Console.ReadLine();
            userData.Add(email);
            Console.Clear();

            return userData;
        }

    }
}