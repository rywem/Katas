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
            if ( dieValues.Count(i => i == 5) == 1 )
                return 50;
            if ( dieValues.Count(i => i == 1) == 1 )
                return 100;
            if ( !dieValues.Any(i => i == 1) )
                return 0;

            
            return 200;
        }
    }   
}
