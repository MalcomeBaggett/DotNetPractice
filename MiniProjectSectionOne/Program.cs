using System;
using System.Collections.Generic;

namespace MiniProjectSectionOne
{
    class Program
    {
        struct party
        {
            public string guestName;
            public int partySize;
        }
        static void Main(string[] args)
        {
            List<party> partySession = new List<party>();
            bool endSession = false;
            Console.WriteLine("Welcome to our self serve guest list!");
            Console.WriteLine("Please follow the prompts below to ensure the best check in experience");
            while (endSession == false)
            {
                party guest = new party();
                guest.guestName = GetName();
                guest.partySize = GetPartyCount();
                partySession.Add(guest);

                Console.WriteLine("Would you like to add another Guest? Yes or No?");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "no")
                {
                    endSession = true;
                }
                int count = 0;
                foreach (var item in partySession)
                {
                    count += item.partySize;
                    Console.Write($"{item.guestName} ");
                }
                Console.WriteLine($"\nThe total number of guests is {count}");
            }
        }
        public Dictionary<string, int> guestBook = new Dictionary<string, int>();
        private static string GetName()
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            return name;
        }
        private static int GetPartyCount()
        {
            Console.WriteLine("Please enter how many people are in your party");
            string partyNumString = Console.ReadLine();
            bool isValidInt = int.TryParse(partyNumString, out int partyNum);
            if (isValidInt == true)
            {
                return partyNum;
            }
            return 1;
        }
    }
}
