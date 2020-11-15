using CodingKatas.Ardalis.Greed;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
namespace CodingKatas.UnitTests.Ardalis.GreedTests
{
    public class GreedScorer_ScoreRollTests
    {

        private GreedScorer _scorer = new GreedScorer();
        [Theory]
        [InlineData(100, 1)]
        [InlineData(200, 1, 1)]

        public void Returns100PerOneFewerThanThree(int expectedValue, params int[] dieValues )
        {
            var result = _scorer.ScoreRoll(dieValues);
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(6)]
        public void Returns0GivenSingleWorthlessValue(int val)
        {
            var result = _scorer.ScoreRoll(val);
            result.Should().Be(0);
        }

        [Theory]
        [InlineData(50, 5)]
        [InlineData(100, 5, 5)]

        public void Returns50PerFiveFewerThanThree( int expectedValue, params int[] dieValues )
        {
            var result = _scorer.ScoreRoll(dieValues);
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(5, 1)]

        public void Returns150GivenOneAndFive( params int[] dieValues )
        {
            var result = _scorer.ScoreRoll(dieValues);
            result.Should().Be(150);
        }

        [Theory]
        [InlineData(1000, 1, 1, 1)]
        [InlineData(1000, 1, 1, 1, 6)]
        [InlineData(1050, 1, 1, 1, 5)]
        [InlineData(1100, 1, 1, 1, 1)]

        public void ReturnsTripleOneScoreAndOtherScoringValues( int expectedValue, params int[] dieValues )
        {
            var result = _scorer.ScoreRoll(dieValues);
            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(200, 2, 2, 2)]
        [InlineData(300, 3, 3, 3)]        
        public void ReturnsTripleGivenThreeTwosThroughSixes( int expectedValue, params int[] dieValues )
        {
            var result = _scorer.ScoreRoll(dieValues);
            result.Should().Be(expectedValue);
        }
    }
}
