using CodingKatas.Agile.Prime;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CodingKatas.UnitTests.Agile.PrimeTests
{
    public class PrimeGeneratorTests
    {
        [Fact]
        public void TestPrimes()
        {
            int[] nullArray = PrimeGenerator.GeneratePrimeNumbers(0);
            Assert.Empty(nullArray);

            int[] minArray = PrimeGenerator.GeneratePrimeNumbers(2);
            Assert.Collection(minArray,
                value => Assert.Equal(2, value)
            );

            int[] threeArray = PrimeGenerator.GeneratePrimeNumbers(3);
            Assert.Collection(threeArray,
                value => Assert.Equal(2, value),
                value => Assert.Equal(3, value)
            );

            int[] centArray = PrimeGenerator.GeneratePrimeNumbers(100);
            Assert.Equal(97, centArray[24]);
        }
    }
}
