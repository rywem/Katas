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
        [Fact]
        public void Returns100GivenSingleOne()
        {
            var scorer = new GreedScorer();

            var result = scorer.ScoreRoll(1);
            result.Should().Be(100);
        }

        [Fact]
        public void Returns200GivenTwoOnes()
        {
            var scorer = new GreedScorer();

            var result = scorer.ScoreRoll(1, 1);            
            result.Should().Be(200);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(6)]
        public void Returns0GivenSingleWorthlessValue(int val)
        {
            var scorer = new GreedScorer();

            var result = scorer.ScoreRoll(val);
            result.Should().Be(0);
        }

        [Fact]
        public void Return50GivenSingleFive()
        {
            var scorer = new GreedScorer();

            var result = scorer.ScoreRoll(5);
            result.Should().Be(50);
        }
    }
}
