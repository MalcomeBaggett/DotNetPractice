using System;
namespace OOP1
{
    public class PersonModel
    {
        // public string firstName;
        // public string lastName;
        // public string email;
        // public string FirstName { get; set; }
        // public string LastName { get; set; }
        // public string EmailAddress { get; set; }
        // public bool HasBeenGreet { get; set; }

        // Auto Props
        public string FirstName { private get; set; }
        public string LastName { get; private set; }
        private string _password;
        public string Password
        {
            set { _password = value; }
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age need to be between 0 and 125");
                }
            }
        }

        private string _ssn;
        public string SSN
        {
            get
            {
                string output = $"***-**-{_ssn.Substring(_ssn.Length - 4)}";
                return _ssn;
            }
            set { _ssn = value; }
        }



    }
}