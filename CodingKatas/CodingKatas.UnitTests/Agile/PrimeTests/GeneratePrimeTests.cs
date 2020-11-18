using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CodingKatas.Agile.Prime;
namespace CodingKatas.UnitTests.Agile.PrimeTests
{
    public class GeneratePrimeTests
    {
        [Fact]
        public void TestPrimes()
        {
            int[] nullArray = GeneratePrime.GeneratePrimeNumbers(0);
            Assert.Empty(nullArray);
            
            int[] minArray = GeneratePrime.GeneratePrimeNumbers(2);
            Assert.Collection(minArray,
                value => Assert.Equal(2, value)
            );

            int[] threeArray = GeneratePrime.GeneratePrimeNumbers(3);
            Assert.Collection(threeArray,
                value => Assert.Equal(2, value),
                value => Assert.Equal(3, value)
            );
            
            int[] centArray = GeneratePrime.GeneratePrimeNumbers(100);
            Assert.Equal(97, centArray[24]);   
        }
    }
}
