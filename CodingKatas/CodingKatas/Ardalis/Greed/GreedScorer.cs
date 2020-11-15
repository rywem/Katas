using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;
namespace CodingKatas.Ardalis.Greed
{
    public class GreedScorer
    {
        public int ScoreRoll( params int[] dieValues )
        {
            int score = 0;

            int fiveCount = dieValues.Count(i => i == 5);            
            if ( fiveCount > 0 )
            {
                score += fiveCount * 50;
            }
            
            int oneCount = dieValues.Count(i => i == 1);
            if ( oneCount >= 3)
            {
                score += 1000;
                oneCount -= 3;
            }
            if ( oneCount > 0 )
            {
                score += oneCount * 100;
            }

            return score;
            
        }
    }   
}
