using System;
using System.Collections.Generic;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            StreetAdresses newStreet = new StreetAdresses();
            newStreet.StreetOne = "123 Main St";
            newStreet.State = "WA";
            newStreet.City = "Bellevue";
            newStreet.ZipCode = "98004";

            Console.WriteLine(newStreet.FullAdress);

            Console.ReadLine();
        }
    }
}
