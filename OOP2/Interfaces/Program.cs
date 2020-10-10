using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public interface IComputerController
        {
            void Connect();
            void CurrentKeyPressed();
        }
        public class Keyboard : IComputerController
        {
            public void Connect()
            {

            }
            public void CurrentKeyPressed()
            {

            }
        }
        public class GameController
        {
            public void Connect()
            {

            }
            public void CurrentKeyPressed()
            {

            }
        }
    }
}
