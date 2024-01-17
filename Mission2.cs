using System;

//Kelsey Corfield Section 001

class DiceSimulate
{
    //Main program
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice would you like to simulate? ");
        int numRolls = int.Parse(Console.ReadLine());

        int[] results = DiceRoll.SimulateDiceRolls(numRolls);

        PrintHistogram(results, numRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    }
    //print histogram (*)
    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 /totalRolls;
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }

    }

}

//get random num for both dice
class DiceRoll
{
    public static int[] SimulateDiceRolls(int numberOfRolls)
    {
        Random rnd = new Random();
        int[] results = new int[13];
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Simulate rolling two dice
            int dice1 = rnd.Next(1, 7);
            int dice2 = rnd.Next(1, 7);
            int sum = dice1 + dice2;

            // Increment the corresponding result in the array
            results[sum]++;
        }

        return results;
    }

}
