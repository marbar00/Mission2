using Mission2;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        DiceRoller dr = new DiceRoller();

        // Ask for the numbner of rolls the user would like to do
        int numRolls = 0;
        Console.WriteLine("Welcome to the dice throwing simulator! ");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        numRolls = int.Parse(Console.ReadLine());

        // Call the rollTheDice method and assign it to results
        int[] results = dr.rollTheDice(numRolls);

        // Print more things to the console
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numRolls + ".");
        Console.WriteLine();

        // print the results as a histogram
        // loop through the results and display as histogram with '*'
        int percent;
        for (int i = 2; i <= 12; i++)
        {
            percent = results[i] * 100 / numRolls;
            Console.WriteLine($"{i}: {new string('*', percent)}");
        }
    }
}