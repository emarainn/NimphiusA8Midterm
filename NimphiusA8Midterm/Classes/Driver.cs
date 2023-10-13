using MidtermRacecarAssignment;

namespace NimphiusA8Midterm.Classes
{
    public abstract class RaceDriver
    {
        public string Name;

        public string Description;

    }

    public class Driver : RaceDriver
    {
        public Driver() 
        {
            Name = "Ema";
            Description = "Best vroom vroom driver ever.";
        }

        public void PersonalDriver()
        {
            string dName, dInfo, cType, cName;

            do
            {
                Console.Write("Enter Driver Name: ");
                dName = Console.ReadLine();
                if (dName == "")
                {
                    Console.WriteLine("\n**Must Enter Driver Name**");
                }
            } while (dName == "");

            do
            {
                Console.Write("Driver Description: ");
                dInfo = Console.ReadLine();
                if (dInfo == "")
                {
                    Console.WriteLine("\n**Must Enter Driver Description**");
                }
            } while (dInfo == "");

            do
            {
                Console.Write("Car Type: ");
                cType = Console.ReadLine();
                if (cType == "")
                {
                    Console.WriteLine("\n**Must Enter Car Type**");
                }
            } while (cType == "");

            do
            {
                Console.Write("Car Name: ");
                cName = Console.ReadLine();
                if (cName == "")
                {
                    Console.WriteLine("\n**Must Enter Car Name**");
                }
            } while (cName == "");

            RaceCar raceCar = new Car();
            RaceDriver raceDriver = new Driver();
            Console.WriteLine("\n\nYour Information VS Your Competition: " +
                "\n----------------------------------------------------" +
                $"\nDriver Name: " +
                $"\n\t{dName} VS {raceDriver.Name}" +
                $"\nDriver Description: " +
                $"\n\tYOU: {dInfo}" +
                $"\n\tCOMP: {raceDriver.Description}" +
                $"\nCar Type & Name: " +
                $"\n\t{cType} named {cName}" +
                $"\n\tVS" +
                $"\n\t{raceCar.CarType} named {raceCar.CarName}" +
                $"\n----------------------------------------------------");

            RacePersonalDriver();

        }

        public void RacePersonalDriver()
        {
            RaceCar raceCar = new Car();
            string ans = null;
            do
            {
                Console.Write("\nWould you like to race your driver? (Y/N): ");
                ans = Console.ReadLine().ToUpper();

                if(ans == "Y")
                {
                    ((Car)raceCar).StartEngine();
                }

            } while (ans == "" || ans != "N");

            


        }
    }
}