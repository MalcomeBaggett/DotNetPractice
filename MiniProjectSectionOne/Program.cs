using System;
using System.Collections.Generic;

namespace MiniProjectSectionOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var sessionDict = Program.guestBook();
            bool endSession = false;
            Console.WriteLine("Welcome to our self serve guest list!");
            Console.WriteLine("Please follow the prompts below to ensure the best check in experience");
            while (endSession == false)
            {
                string userName = GetName();
                int partyCount = GetPartyCount();
                Program.AddParty(sesstionDict, userName, partyCount);
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
        private static Dictionary<int, string> AddParty(dictionary<int, string> guestBook, string userName, int partyCount)
        {
            guestBook[userName] = partyCount;
            Console.WriteLine($"Your Party has been logged {userName}, please proceed.");
            return guestBook;
        }
    }
}
