using System;
using System.Collections.Generic;

namespace MethodOveriding
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel
            {
                FirstName = "M",
                LastName = "B",
            };
            Console.WriteLine(person);
        }
        public class PersonModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return $"{FirstName} {LastName}";
            }
        }

        public class EmployeeModel
        {
            public decimal HourlyRate { get; set; }

            public virtual decimal GetPaycheckAmount(int hoursWorked)
            {
                return HourlyRate * hoursWorked;
            }
        }
        public class CommisionEmployeeModel : EmployeeModel
        {
            public decimal CommisionAmount { get; set; }
            public override decimal GetPaycheckAmount(int hoursWorked, int commsionAmount)
            {
                return base.GetPaycheckAmount(hoursWorked) + commsionAmount;
            }
        }
    }
}
