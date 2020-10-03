using System;

namespace OOP1
{
    public class UserMessages
    {
        public static void StartMessage(string userName)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Applicaction");
            int hourOfDay = DateTime.Now.Hour;

            if (hourOfDay < 12)
            {
                Console.WriteLine($"Good Morning {userName}!");
            }
            else
            {
                Console.WriteLine($"Good Evening {userName}!");
            }
        }

    }
}