namespace OOP1
{
    public class RequestData
    {
        public static double GetDouble(string message)
        {
            double output;
            Console.WriteLine(message);
            string dbl = Console.ReadLine();
            bool isDouble = double.TryParse(dbl, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number please try again");
                Console.Write(message);
                dbl = Console.ReadLine();

                isDouble = double.TryParse(dbl, out output);
            }
            return output;

        }
    }
}