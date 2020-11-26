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
            /*
            string two = results[1];
            Assert.Equal("2", two);
            string four = results[3];
            Assert.Equal("4", four);
            string seven = results[6];
            Assert.Equal("7", seven);

            string fiftyOne = results[50];
            Assert.Equal("51", fiftyOne);

            string ninetyEight = results[97];
            Assert.Equal("98", ninetyEight);
            */
        }

        [Fact]
        public void WhenDivisibleBy3_PrintFizz()
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();
            
            string three = results[2];
            Assert.Equal("Fizz", three);

            string six = results[5];
            Assert.Equal("Fizz", six);
        }

        [Fact]
        public void WhenDivisibleBy5_PrintBuzz()
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();
            
            string five = results[4];
            Assert.Equal("Buzz", five);

            string ten = results[9];
            Assert.Equal("Buzz", ten);
        }

        [Fact]
        public void WhenDivisibleBy3And5_PrintFizzBuzz()
        {
            FizzBuzzClass fizzBuzzClass = new FizzBuzzClass();
            var results = fizzBuzzClass.FizzBuzzResultArray();

            string fifteen = results[14];
            Assert.Equal("FizzBuzz", fifteen);

            string thirty = results[29];
            Assert.Equal("FizzBuzz", thirty);
        }
    }
}
