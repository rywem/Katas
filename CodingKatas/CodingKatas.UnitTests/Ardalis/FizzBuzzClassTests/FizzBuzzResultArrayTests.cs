using CodingKatas.Ardalis.FizzBuzz;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingKatas.UnitTests.Ardalis.FizzBuzzTests
{
    public class FizzBuzzResultArrayTests
    {
        [Fact]
        public void ResultArrayReturns100Length()
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var result = fizzBuzzClass.FizzBuzzResultArray();
            int length = result.Length;

            Assert.Equal(100, length);
        }

        [Theory]
        [InlineData("1", 0)]
        [InlineData("2", 1)]
        [InlineData("4", 3)]
        [InlineData("7", 6)]        
        [InlineData("98", 97)]
        public void ResultArrayReturnsArrayWithNumberStringValues(string expected, int index)
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();
            string one = results[index];
            Assert.Equal(expected, one);            
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5)]        
        public void WhenDivisibleBy3_PrintFizz(int index)
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();
            
            string fizz = results[index];
            Assert.Equal("Fizz", fizz);
            
        }

        [Theory]
        [InlineData(4)]
        [InlineData(9)]
        public void WhenDivisibleBy5_PrintBuzz(int index)
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();
            
            string buzz = results[index];
            Assert.Equal("Buzz", buzz);
        }

        [Theory]
        [InlineData(14)]
        [InlineData(29)]
        public void WhenDivisibleBy3And5_PrintFizzBuzz(int index)
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();

            string fizzBuzz = results[index];
            Assert.Equal("FizzBuzz", fizzBuzz);
        }
    }
}
