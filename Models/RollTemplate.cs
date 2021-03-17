using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreedKata.Models
{
    public class RollTemplate
    {
        public int Score;
        public int[] DiceNumbers;

        public RollTemplate(int score, int[] nums)
        {
            Score = score;
            DiceNumbers = nums;
        }
    }
}
