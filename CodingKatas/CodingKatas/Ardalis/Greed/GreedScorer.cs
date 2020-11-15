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

            int oneCount = dieValues.Count(i => i == 1);
            if ( oneCount >= 3 )
            {
                score += 1000;
                oneCount -= 3;
            }
            if ( oneCount > 0 )
            {
                score += oneCount * 100;
            }

            
            score += ScoreTripleDieValue(2, dieValues.Count(i => i == 2));
            score += ScoreTripleDieValue(3, dieValues.Count(i => i == 3));


            int fiveCount = dieValues.Count(i => i == 5);            
            if ( fiveCount > 0 )
            {
                score += fiveCount * 50;
            }
            
            return score;
        }


        private int ScoreTripleDieValue(int dieValue, int count )
        {
            if ( count == 3 )
                return dieValue * 100;
            else
                return 0;
        }
    }   
}
