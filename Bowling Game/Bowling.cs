using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game
{
    public class Bowling
    {
        int[] rolls = new int[21];
        int currentRoll = 0;
        private int frames = 10;
        public int calculateScore()
        {
            int score = 0;
            int rollturn = 0;
            for (var i = 0; i < frames; i++)
            {
                if (isStrike(rollturn))
                {
                    score += 10 + rolls[rollturn + 1] + rolls[rollturn + 2];
                    rollturn++;
                }
                else if (isSpare(rollturn))
                {
                    score += 10 + rolls[rollturn + 2];
                    rollturn += 2;
                }
                else //standard score
                {
                    score += rolls[rollturn] + rolls[rollturn + 1];
                    rollturn += 2;
                }
            }
            return score;
        }

        public void roll(int pins)
        {
            rolls[currentRoll++] = pins;
        }
        private bool isStrike(int rollturn)
        {
            return rolls[rollturn] == 10;
        }

        private bool isSpare(int rollturn)
        {
            return rolls[rollturn] + rolls[rollturn + 1] == 10;
        }
    }
}
