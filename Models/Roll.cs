using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreedKata.Models
{
    public class Roll
    {
        // represents the score obtained by the dice rolls
        private int score;

        // represents the values of the dice rolls
        private int[] diceNumbers;

        public int getScore()
        {
            return score;
        }

        public int[] getDiceNumbers()
        {
            return diceNumbers;
        }
        
        public void setDiceNumbers(int[] nums)
        {
            diceNumbers = nums;
        }

        // gets random values for each of the 5 dice rolls and stores them in the diceNumbers class variable
        public void rollDiceRandom()
        {
            var rand = new Random();

            diceNumbers = new int[5];

            // generate 5 random integers between 1 and 6 and store them in diceNumbers
            for (int i = 0; i < 5; i++)
            {
                diceNumbers[i] = rand.Next(1, 7);
            }
        }

        // calculates the score obtained by the values stored in the diceNumbers class variable
        public void calculateScore()
        {
            // stores key value pairs of the rolled number and its frequency in the list in this order
            Dictionary<int, int> numHash = new Dictionary<int, int>();

            for (int i = 0; i < diceNumbers.Length; i++)
            {
                // if the dictionary contains a key with the value of the current number in the list, increment the count
                if (numHash.ContainsKey(diceNumbers[i]))
                {
                    numHash[diceNumbers[i]]++;
                }
                else
                {
                    numHash.Add(diceNumbers[i], 1);
                }
            }

            // stores the current total score
            int total = 0;

            foreach (KeyValuePair<int, int> pair in numHash)
            {
                // score logic for each possible number value
                if (pair.Key == 1)
                {
                    total += pair.Value / 3 * 1000;
                    total += pair.Value % 3 * 100;
                }
                else if (pair.Key == 2)
                {
                    total += pair.Value / 3 * 200;
                }
                else if (pair.Key == 3)
                {
                    total += pair.Value / 3 * 300;
                }
                else if (pair.Key == 4)
                {
                    total += pair.Value / 3 * 400;
                }
                else if (pair.Key == 5)
                {
                    total += pair.Value / 3 * 500;
                    total += pair.Value % 3 * 50;
                }
                else if (pair.Key == 6)
                {
                    total += pair.Value / 3 * 600;
                }
            }

            score = total;

        }

        // display values of diceNumbers
        public void outputDiceValues()
        {
            Console.Write("Values: ");

            for (int i = 0; i < diceNumbers.Length; i++)
            {
                Console.Write(diceNumbers[i] + " ");
            }
        }

        public void displayScore()
        {
            Console.Write("Score: " + score);
        }
    }
}
