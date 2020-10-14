using System;

namespace ExtentsionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            "Hello".PrintToConsole();
            HotelRoomModel room304 = new HotelRoomModel();
            room304.OpenShades().CloseShades();
            Console.WriteLine(room304.AreShadesOpen);
            PersonModel malcome = new PersonModel();
            malcome.Name = "Malcome Baggett";
            malcome.SetDefaultAge(30).PrintInfo();
        }

    }
    public class PersonModel
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    public static class PersonExtensionMethods
    {
        public static PersonModel SetDefaultAge(this PersonModel person, int age)
        {
            person.Age = age;
            return person;
        }
        public static PersonModel PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            return person;
        }
    }
    public class HotelRoomModel
    {
        public int Tempeture { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }
    public static class ExtentionMethodSample
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }
        public static HotelRoomModel SetTempeture(this HotelRoomModel room, int temp)
        {
            room.Tempeture = temp;
            return room;
        }
        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }
        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }
}
