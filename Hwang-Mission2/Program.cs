using System;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user
            Console.WriteLine("Welcome to the dice throwing simulator!");

            Console.WriteLine("How many dice rolls would you like to simulate?: ");
            int numRolls = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            double[] rollTotals = new double[13];

            //Simulate the roll of the die
            for (int i = 0; i < numRolls; i++)
            {
                int roll = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                rollTotals[roll + roll2]++;
            }

            //Print out the results from the array
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine();
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = 1000.");

            for (int i = 2; i < 13; ++i)
            {
                double asterick = (rollTotals[i] / numRolls) * 100;
                Console.Write(i + ": ");
                for (int j = 0; j < Math.Floor(asterick); ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
