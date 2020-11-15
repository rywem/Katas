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

            LoadDieValueCounts(dieValues);
            

            int score = 0;

            score += ScoreTripleOneValue();
            score += ScoreSingleOneValues();


            for ( int dieValue = 2; dieValue <= 6; dieValue++ )
            {
                score += ScoreTripleDieValue(dieValue);
            }


            score += ScoreSingleFiveValues();
            
            return score;
        }

        private void LoadDieValueCounts(int[] dieValues )
        {
            for ( int i = 1; i <= 6; i++ )
            {
                _dieValueCounts.Add(i, dieValues.Count(die => die == i));
            }
        }

        private int ScoreSingleOneValues()
        {
            int score = _dieValueCounts[1] * 100;
            _dieValueCounts[1] = 0;
            return score;            
        }

        private int ScoreSingleFiveValues()
        {
            int score = _dieValueCounts[5] * 50;
            _dieValueCounts[5] = 0;
            return score;
        }

        private int ScoreTripleOneValue()
        {
            if ( _dieValueCounts[1] >= 3 )
            {
                _dieValueCounts[1] -= 3;
                return 1000;
            }
            return 0;
        }

        private int ScoreTripleDieValue(int dieValue)
        {
            if ( _dieValueCounts[dieValue] >= 3 )
            {
                _dieValueCounts[dieValue] -= 3;
                return dieValue * 100;
            }

            return 0;
        }
    }   
}
