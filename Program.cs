using System;
using diceRoll;
using diceSimulate;

//Kelsey Corfield Section 001


//print histogram (*)

namespace diceSimulate
{
    public class HistogramPrinter
    {

        public static void PrintHistogram(int[] results, int totalRolls)
        {
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {totalRolls}.");

            for (int i = 2; i <= 12; i++)
            {
                int percentage = results[i] * 100 / totalRolls;
                string asterisks = new string('*', percentage);
                Console.WriteLine($"{i}: {asterisks}");
            }
        }
    }

}



