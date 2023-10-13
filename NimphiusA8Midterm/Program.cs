using System;
using System.Runtime.CompilerServices;
using NimphiusA8Midterm.Classes;

namespace MidtermRacecarAssignment
{
    class Program 
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Race Track!" +
                "\nI hope You're Ready to RACE!" +
                "\n--------------------------------");

            UserInput();
        }

        public static void UserInput()
        {
            RaceCar raceCar = new Car();
            RaceDriver raceDriver = new Driver();
            string ans;
            do
            {
                Console.Write("\nWhat Would You Like To Do?" +
                    "\n1. Create and Race Your Own Driver" +
                    "\n2. Race Premade Drivers" +
                    "\nX. To Exit Application" +
                    "\nEnter Option Here: ");
                ans = Console.ReadLine().ToUpper();

                if (ans == "1")
                {
                    ((Driver)raceDriver).PersonalDriver();
                }
                else if (ans == "2")
                {
                    AutoRace();
                }

            } while (ans != "X" || ans == "");
        }

        public static void AutoRace() {
            RaceCar raceCar = new Car();
            ((Car)raceCar).StartEngine();
            string option;
            do
            {
                Console.Write("\nWould you like to continue or break your car?" +
                    "\n1. Continue" +
                    "\n2. Break Car" +
                    "\nYour Input: ");
                option = Console.ReadLine();

                if (option == "1")
                {
                    ((Car)raceCar).StartEngine();
                }
                else if (option == "2")
                {
                    ((Car)raceCar).Break();
                }
            } while (option == "");


        }
    }
}