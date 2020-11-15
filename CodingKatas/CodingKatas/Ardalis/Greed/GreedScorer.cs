using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;
namespace CodingKatas.Ardalis.Greed
{
    public class GreedScorer
    {

        private Dictionary<int, int> _dieValueCounts = new Dictionary<int, int>();
        public int ScoreRoll( params int[] dieValues )
        {

            for ( int i = 1; i <= 6; i++ )
            {
                _dieValueCounts.Add(i, dieValues.Count(die => die == i));
            }

            int score = 0;

            if ( _dieValueCounts[1] >= 3 )
            {
                score += 1000;
                _dieValueCounts[1] -= 3;
            }
            if ( _dieValueCounts[1] > 0 )
            {
                score += _dieValueCounts[1] * 100;
            }


            for ( int dieValue = 2; dieValue <= 6; dieValue++ )
            {
                score += ScoreTripleDieValue(dieValue, 
                    _dieValueCounts[dieValue]);
            }            

            
            if ( _dieValueCounts[5] > 0 )
            {
                score += _dieValueCounts[5] * 50;
            }
            
            return score;
        }


        private int ScoreTripleDieValue(int dieValue, int count )
        {
            if ( count == 3 )
            {
                _dieValueCounts[dieValue] -= 3;
                return dieValue * 100;
            }

            else
                return 0;
        }
    }   
}
