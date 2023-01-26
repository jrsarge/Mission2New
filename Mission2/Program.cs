//Jacob Sargent
//1.18.23
//Dice Rolling Simulator

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            int diceRolls;
            Console.WriteLine("Welcome to the dice throwing simulator!" +"\n");
            Console.WriteLine("Enter how many dice rolls you would like to simulate:" + "\n");

            //Grab whatever number the user inputted
            diceRolls = Convert.ToInt32(Console.ReadLine());

            //Make an array that has enough positions to account for the number of times the 
            //user wanted to roll the dice
            int[] allRolls = new int[diceRolls];

            //For each dice roll, generate the number and save that to an array
            for (int i = 0; i < diceRolls; i++)
            {
                Random rnd = new Random();
                int rollValue = rnd.Next(2, 13);

                allRolls[i] = rollValue;
            }

            //Make an array with 12 positions
            int[] totalsArray = new int[13];

            //This makes an array of totals where the position in that array gives the total times that number
            //was rolled so we just need to get the next number in allRolls, go to that position in totalsArray
            //and increment it one
            for (int i = 0; i < allRolls.Length; i++)
            {
                totalsArray[(allRolls[i])]++;
            }

            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS" + "\n" +
                "Each \"*\" represents 1% of the total number of rolls." + "\n" +
                "Total number of rolls = " + diceRolls + "\n");

            //Starting at a count of two go through the totalsArray and find the perecentage for each number
            //and then convert those to the coordinating number of *'s and print it
            for(int i = 2; i < totalsArray.Length; i++)
            {
                int numTotal = totalsArray[i];
                int output = ((numTotal * 100) / diceRolls);

                string realOutput = "";

                for(int j = 0; j < output; j++)
                {
                    realOutput = realOutput + "*";
                }

                Console.WriteLine(i + ": " + realOutput);
            }

            Console.WriteLine("\n" + "Thank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
