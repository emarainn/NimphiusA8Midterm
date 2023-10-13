using System;

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
            List<int> yourWins = new List<int>();
            List<int> compWins = new List<int>();

            RaceDriver raceDriver = new Driver();
            int yourMPH = 0;
            int roundNum = 0;
            int rounds = 1;
            int i = 0;
            Random rnd = new Random();
            int compMPH = rnd.Next(1, 150);
            int winner = 0;



            Console.Write("Enter # of Rounds You Would Like to Play: ");

            while (!int.TryParse(Console.ReadLine(), out roundNum) || roundNum <= 0)
            {
                Console.WriteLine("\n**Must Enter Number Greater Than 0**");
                Console.Write("Enter Number of Rounds: ");
            }

            for (i = 0; i < roundNum; i++)
            {
                Console.Write($"\nEnter speed you want to go for round {rounds}: ");

                while (!int.TryParse(Console.ReadLine(), out yourMPH) || yourMPH <= 0 || yourMPH > 150)
                {
                    Console.WriteLine("\n**Must Enter Number between 1 and 150**");
                    Console.Write("Enter MPH you are going this Roud (1 - 150): ");
                }

                Console.WriteLine($"\nFor Round {rounds}:" +
                    $"\nYou are going: {yourMPH}MPH" +
                    $"\n{raceDriver.Name} is going: {compMPH}MPH");

                winner = Math.Max(yourMPH, compMPH);

                if (winner == yourMPH)
                {
                    Console.WriteLine("YOU WON!!!");
                    yourWins.Add(1);
                }
                else
                {
                    Console.WriteLine($"{raceDriver.Name} won");
                    compWins.Add(1);
                }

                Console.Write("Enter B to Break or enter to continue to next round: ");
                string ans = Console.ReadLine().ToUpper();

                if (ans == "B")
                {
                    Break();
                    break;
                }

                rounds++;
            }

            Console.WriteLine("\n------------------------" +
                "\nEND RESULTS OF RACE:");

            if (yourWins.Sum() > compWins.Sum())
            {
                Console.WriteLine($"You Won: {yourWins.Sum()}" +
                    $"\n{raceDriver.Name} only won {compWins.Sum()}");
            }
            else if (compWins.Sum() > yourWins.Sum())
            {
                Console.WriteLine($"{raceDriver.Name} OBVIOUSLY Won: {compWins.Sum()}" +
                    $"\nYou only won {yourWins.Sum()}");
            }
            else if (compWins.Sum() ==  yourWins.Sum())
            {
                Console.WriteLine("Tie... GROSS");
            }
        }

        public void Break()
        {
            Console.WriteLine("You stopped your car and are out of the race...");
        }
    }
}