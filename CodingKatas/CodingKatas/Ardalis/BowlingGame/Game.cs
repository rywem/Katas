using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingKatas.Ardalis.BowlingGame
{
    public class Game
    {
        private List<int> ScoreCard;

        public Game()
        {
            ScoreCard = new List<int>();
        }
        public void Roll( int pins )
        {
            ScoreCard.Add(pins);
        }

        public int Score()
        {
            int score = 0;
            bool isBonus = false;
            bool isNewRound = true;
            int prevRoundTotal = 0;
            int currentRoundTotal = 0;            
            int currentRound = 1;
            int currentRoll = 0;
            for ( int i = 0; i < ScoreCard.Count; i++ )
            {
                if ( currentRound == 11 )
                {
                    score += ScoreCard[i] + prevRoundTotal;
                    return score;
                }

                if ( isNewRound == true )
                    currentRoundTotal = ScoreCard[i];
                else
                    currentRoundTotal += ScoreCard[i];

                currentRoll++;

                if ( isBonus )
                {
                    score += prevRoundTotal + ScoreCard[i];
                    isBonus = false;
                }

                if ( currentRoundTotal == 10 || currentRoll == 2 )
                {
                    currentRound++;
                    currentRoll = 0;
                    isNewRound = true;
                    if ( currentRoundTotal == 10 )
                    {
                        prevRoundTotal = currentRoundTotal;
                        isBonus = true;
                    }
                    else
                    {
                        score += currentRoundTotal;
                    }
                }
                else
                    isNewRound = false;
            }
            return score;
        }

       
    }
}
