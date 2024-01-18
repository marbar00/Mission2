using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class DiceRoller
    {
        public int[] rollTheDice(int numRolls)
        {
            // make my dice variables
            int dice1;
            int dice2;
            int sum;

            // make array to hold count of each number rolled
            int[] results = new int[13];

            // Create random as an object
            Random rand = new Random();

            // loop through each roll
            for (int i = 0; i < numRolls; i++)
            {
                // roll my dice
                dice1 = rand.Next(1, 7);
                dice2 = rand.Next(1, 7);
                sum = dice1 + dice2;

                results[sum]++;
            }
            return results;
        }
    }
}
