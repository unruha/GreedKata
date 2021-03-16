using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreedKata.Models
{
    public class Roll
    {
        // represents the score obtained by the dice rolls
        private int score { get; set; }

        // represents the values of the dice rolls
        private int[] diceNumbers { get; set; }
        

        // gets random values for each of the 5 dice rolls and stores them in the diceNumbers class variable
        public void rollDiceRandom()
        {
            var rand = new Random();

            this.diceNumbers = new int[5];

            // generate 5 random integers between 1 and 6 and store them in diceNumbers
            for (int i = 0; i < 5; i++)
            {
                diceNumbers[i] = rand.Next(1, 7);
            }

            // print the output to console
            for (int i = 0; i < diceNumbers.Length; i++)
            {
                Console.WriteLine(diceNumbers[i]);
            }
        }
    }
}
