using System;
using System.Collections.Generic;

namespace Events
{
    public static class ConsoleHelper
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }
    }
    class Program
    {
        private static void CollegeClass_EnrollmentFul(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender;
            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle}: FULL");
            Console.WriteLine();
        }
        private static void Inventory_Full(object send, string e)
        {
            Console.WriteLine();
            Console.WriteLine(e);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // CollegeClassModel math101 = new CollegeClassModel("Math 101", 3);
            // CollegeClassModel History101 = new CollegeClassModel("History 101", 2);
            // math101.EnrollmentFull += CollegeClass_EnrollmentFul;
            // math101.SignUpStudent("Fion").PrintToConsole();
            // math101.SignUpStudent("Fion").PrintToConsole();
            // math101.SignUpStudent("Fion").PrintToConsole();
            // math101.SignUpStudent("Fion").PrintToConsole();
            // Console.WriteLine();
            // History101.EnrollmentFull += CollegeClass_EnrollmentFul;
            // History101.SignUpStudent("Wunsa").PrintToConsole();
            // History101.SignUpStudent("Wunsa").PrintToConsole();
            // History101.SignUpStudent("Wunsa").PrintToConsole();
            // History101.SignUpStudent("Wunsa").PrintToConsole();
            PlayerClass malcome = new PlayerClass("Malcome");
            malcome.InventoryFull += Inventory_Full;
            malcome.AddInvetory("Gold");
            malcome.AddInvetory("Gold");
            malcome.AddInvetory("Gold");
            Console.ReadLine();
        }

        public class CollegeClassModel
        {
            public event EventHandler<string> EnrollmentFull;
            private List<string> enrolledStudents = new List<string>();
            private List<string> waitingList = new List<string>();

            public string CourseTitle { get; private set; }
            public int MaxStudents { get; private set; }
            public CollegeClassModel(string title, int maxStudents)
            {
                CourseTitle = title;
                MaxStudents = maxStudents;
            }
            public void GetListCounts()
            {
                Console.WriteLine($"Enrolled: {enrolledStudents.Count}, Waiting List Count: {waitingList.Count}");
            }

            public string SignUpStudent(string studentName)
            {
                string output = "";
                if (enrolledStudents.Count < MaxStudents)
                {
                    enrolledStudents.Add(studentName);
                    output = $"{studentName} was added to the enrolled list";

                    if (this.enrolledStudents.Count == MaxStudents)
                    {
                        // check if class is full
                        EnrollmentFull?.Invoke(this, $"{this.CourseTitle} is full");
                    }

                }
                else
                {
                    waitingList.Add(studentName);
                    output = $"{studentName} was added to the waiting list";
                }
                return output;
            }
        }
    }
}
