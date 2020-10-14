using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel();
            Console.ReadLine();
        }
        public class PersonModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public PersonModel(string firstName, string lastName, string email)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
            }
            public PersonMode(string email)
            {
                Email = email;
            }
        }
        public class EmployeeModel
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Pay { get; set; }

            public EmployeeModel(int id)
            {
                ID = id;
            }
            public EmployeeModel(string firstName, string lastName, int id, int pay)
            {
                FirstName = firstName;
                LastName = lastName;
                ID = id;
                Pay = pay;
            }
        }
    }
}
