using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BowlingGameTest
{
    class Game
    {
        private int[] rolls = new int[21];
        private int currentRoll = 0;

        public void roll(int pins) 
        {
            rolls[currentRoll++] = pins;
        }

        public int score() 
        {
            int _score = 0;

            int frameIndex = 0;
            for (int frame = 0; frame < 10; frame++)
            {
                if(isStrike(frameIndex))
                {
                    _score += 10 + strikeBonus(frameIndex);
                    frameIndex ++;
                }
                else if(isSpare(frameIndex))
                {
                    _score += 10 + spareBonus(frameIndex);
                    frameIndex += 2;
                }
                else
                {
                    _score += sumOfBallsInFrame(frameIndex);
                    frameIndex += 2;
                }
                
            }
            return _score;
        }
        private bool isSpare(int frameIndex) 
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
        private bool isStrike(int frameIndex) 
        {
            return rolls[frameIndex] == 10;
        }
        private int strikeBonus(int frameIndex)
        {
            return rolls[frameIndex + 1] + rolls[frameIndex + 2];
        }
        private int spareBonus(int frameIndex) 
        {
            return rolls[frameIndex + 2];
        }
        private int sumOfBallsInFrame(int frameIndex) 
        {
            return rolls[frameIndex] + rolls[frameIndex + 1];
        }
    }
}
