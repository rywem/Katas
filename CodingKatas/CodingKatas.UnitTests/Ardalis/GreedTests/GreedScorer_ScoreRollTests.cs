﻿using CodingKatas.Ardalis.Greed;
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

        public void Returns100PerOneFewerThanThree(int expectedValue, params int[] ones )
        {
            var result = _scorer.ScoreRoll(ones);
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

        public void Returns50PerFiveFewerThanThree( int expectedValue, params int[] fives )
        {
            var result = _scorer.ScoreRoll(fives);
            result.Should().Be(expectedValue);
        }
    }
}
