using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            BadCall();
        }
        private static void BadCall()
        {
            int[] ages = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i <= ages.Length; i++)
            {
                try
                {
                    Console.WriteLine(ages[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine((ex.Message));
                    throw;
                }
            }
            Console.ReadLine();
        }
    }
}
