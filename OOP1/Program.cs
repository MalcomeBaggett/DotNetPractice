using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            UserMessages.StartMessage(name);
            Console.ReadLine();
        }
    }
}
