using System;
using System.Threading;
using Xunit;

namespace Reaktionsspelet.Tests
{
    public class ReaktionsspeletTests
    {
        [Fact]
        public void SleepFor3Seconds()
        {
            // arrange
            int sleepTime = 3000;

            // act
            Thread.Sleep(sleepTime);

            // assert
            Assert.Equal(3000, sleepTime);
        }

        [Fact]
        public void GenerateARandomNumberBetween3000And10000()
        {
            // arrange
            Random rnd = new Random();
            int minValue = 3000;
            int maxValue = 10000;

            // act
            int randNum = rnd.Next(minValue, maxValue);

            // assert
            Assert.True(randNum >= minValue);
            Assert.True(randNum <= maxValue);
            
        }
    }
}
