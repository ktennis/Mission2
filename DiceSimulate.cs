using System;
using diceRoll;

namespace diceSimulate
{
    class DiceSimulate
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice would you like to simulate? ");
            int numRolls = int.Parse(Console.ReadLine());

            int[] results = DiceRoll.SimulateDiceRolls(numRolls);

            HistogramPrinter.PrintHistogram(results, numRolls);

            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

        }
    }

}
