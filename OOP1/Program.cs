using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            RequestData sessionData = new RequestData();
            string command = "";
            List<PersonModel> people = new List<PersonModel>();
            do
            {
                Console.WriteLine("Please enter in any key to begin registration (type exit to stop app)");
                command = Console.ReadLine();
                if (command.ToLower() != "exit")
                {
                    PersonModel person = new PersonModel();
                    List<string> data = sessionData.reqUserData();
                    person.FirstName = data[0];
                    person.LastName = data[1];
                    person.EmailAddress = data[2];
                    Console.WriteLine(data.Count);
                    people.Add(person);
                }
            }
            while (command.ToLower() != "exit");

            foreach (PersonModel p in people)
            {
                Console.WriteLine($"{p.FirstName} {p.LastName} {p.EmailAddress}");
            }
            Console.ReadLine();
        }
    }
}
