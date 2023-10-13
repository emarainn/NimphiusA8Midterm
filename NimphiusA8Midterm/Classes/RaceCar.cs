namespace NimphiusA8Midterm.Classes
{
    public abstract class RaceCar
    {
        public string CarName { get; set; }

        public string CarType { get; set; }
        public int MPH { get; set; }

    }

    public class Car : RaceCar
    {

        public Car()
        {
            CarName = "Swiss Cheese";
            CarType = "Toyota Prius";
            MPH = 50;
        }

        public void StartEngine()
        {

            List<int> yourSpeed = new List<int>();
            List<int> compSpeed = new List<int>();

            RaceDriver raceDriver = new Driver();
            int yourMPH = 0;
            int roundNum = 0;

            Console.Write("Enter speed you want to go this round: ");

            while (!int.TryParse(Console.ReadLine(), out yourMPH) || yourMPH <= 0 || yourMPH > 150)
            {
                Console.WriteLine("\n**Must Enter Number between 1 and 150**");
                Console.Write("Enter MPH you are going this Roud (1 - 150): ");
            }

            Random rnd = new Random();
            int compMPH = rnd.Next(1, 150);

            Console.WriteLine($"\nThis Round:" +
                $"\nYou are going: {yourMPH}MPH" +
                $"\n{raceDriver.Name} is going: {compMPH}MPH");

            var winner = Math.Max(yourMPH, compMPH);

            if (winner == yourMPH)
            {
                Console.WriteLine("YOU WON!!!");
            }
            else
            {
                Console.WriteLine($"Obviously {raceDriver.Name} is better then you. SUCKER");
            }
        }

        public void Break()
        {
            Console.WriteLine("You stopped your car and are out of the race...");
        }
    }
}