using CodingKatas.ProjectEuler.Problem023;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingKatas.UnitTests.ProjectEuler.Problem023
{
    public class NonAbundantSumTests
    {

        [Theory]
        [InlineData(6, 1, 2, 3)]
        [InlineData(12, 1, 2, 3, 4, 6)]
        [InlineData(16, 1, 2, 4, 8)]
        public void GetDivisors_ListOfNumbers(int number, params int[] expected)
        {
            NonAbundantSums abundantSums = new NonAbundantSums();
            var actual = abundantSums.GetDivisors(number);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 1, 2, 3)]
        [InlineData(7, 1, 2, 4)]
        [InlineData(16, 1, 2, 3, 4, 6)]
        public void SumDivisors_ReturnSum(int expectedSum, params int[] divisors)
        {
            NonAbundantSums abundantSums = new NonAbundantSums();
            var actualSum = abundantSums.SumDivisors(divisors);
            Assert.Equal(expectedSum, actualSum);
        }

        [Theory]
        [InlineData(6, 6, false)]
        [InlineData(12, 16, true)]
        [InlineData(8, 7, false)]
        public void IsAbundant_CompareSums(int number, int sum, bool expected)
        {
            NonAbundantSums abundantSums = new NonAbundantSums();
            var actual = abundantSums.IsAbundant(number, sum);
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 12)]
        [InlineData(1, 18)]
        [InlineData(2, 20)]
        public void FindAllAbundant_GetAbundantAtIndex(int index, int expectedNumber)
        {
            NonAbundantSums abundantSums = new NonAbundantSums();
            var fullList = abundantSums.FindAllAbundant();
            var actual = fullList[index];
            Assert.Equal(expectedNumber, actual);
        }

        [Theory]
        [InlineData(0, 24)]
        [InlineData(1, 30)]
        [InlineData(2, 32)]
        public void SumAbundants_GetValueAtIndex(int index, int expected)
        {
            NonAbundantSums abundantSums = new NonAbundantSums();
            var fullList = abundantSums.SumAbundants();
            var actual = fullList[index];
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SumOfNonAbundants_GetSum()
        {
            NonAbundantSums abundantSums = new NonAbundantSums();
            var actual = abundantSums.SumOfNonAbundants();
            Assert.Equal(4179871, actual);
        }
    }
}
