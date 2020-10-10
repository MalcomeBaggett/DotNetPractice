using System;
namespace OOP1
{
    public class StreetAdresses
    {
        public string ZipCode { get; set; }
        public string StreetOne { get; set; }
        public string State { get; set; }
        public string City { get; set; }

        private string _fullAdress;
        public string FullAdress
        {
            get { return $"Street Adress: {StreetOne}\nCity and State: {City}, {State}\nZipcode: {ZipCode}"; }

        }

    }
}