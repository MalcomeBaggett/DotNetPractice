using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Spell fireball = new FireBall();
            Console.WriteLine(fireball.DealDamage());
        }
        public interface IDamage
        {
            int DealDamage();
        }
        public abstract class Spell : IDamage
        {
            public int DealDamage()
            {
                return 6;
            }
        }

        public class FireBall : Spell
        {

        }
    }
}
