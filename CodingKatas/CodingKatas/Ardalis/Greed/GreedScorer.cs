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
            if ( !dieValues.Any(i => i == 1) )
                return 0;
            if ( dieValues.Count(i => i == 1) == 1 )
            {
                return 100;
            }
            return 200;
        }
    }

    public class Dice : IEquatable<Dice>
    {
        public int CurrentRoll { get; set; }
        private Random _random;
        public Dice()
        {

        }

        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll()
        {
            Random random = new Random();
            CurrentRoll = random.Next(1, 6);
            return CurrentRoll;
        }

        public bool Equals( [AllowNull] Dice other )
        {
            if ( other == null )
                return false;

            return this.CurrentRoll == other.CurrentRoll;
        }
    }
}
