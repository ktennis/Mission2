using System;

//get random num for both dice
namespace diceRoll
{
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
}