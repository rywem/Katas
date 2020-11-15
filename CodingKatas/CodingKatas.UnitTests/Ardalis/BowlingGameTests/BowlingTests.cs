using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CodingKatas.Ardalis.BowlingGame;
namespace CodingKatas.UnitTests.Ardalis.BowlingGameTests
{
    public class BowlingTests
    {
        [Fact] 
        public void TestScoreAfterRound1_NoStrike()
        {
            Game bowling = new Game();

            bowling.Roll(5);
            bowling.Roll(1);

            Assert.Equal(6, bowling.Score());
        }

        [Fact]
        public void TestScoreRound2_WithBonus()
        {
            Game bowling = new Game();

            bowling.Roll(5);
            bowling.Roll(5);
            bowling.Roll(5);
            bowling.Roll(1);

            Assert.Equal(21, bowling.Score());
        }

        [Fact]
        public void TestScoreRound10_WithBonus()
        {
            Game bowling = new Game();
            // r1
            bowling.Roll(1);
            bowling.Roll(1);
            // r2
            bowling.Roll(1);
            bowling.Roll(1);
            // r3
            bowling.Roll(1);
            bowling.Roll(1);
            // r4
            bowling.Roll(1);
            bowling.Roll(1);
            // r5
            bowling.Roll(1);
            bowling.Roll(1);
            //r6 
            bowling.Roll(1);
            bowling.Roll(1);
            //r7
            bowling.Roll(1);
            bowling.Roll(1);
            //r8
            bowling.Roll(1);
            bowling.Roll(1);
            //r9
            bowling.Roll(1);
            bowling.Roll(1);
            //r10
            bowling.Roll(5);
            bowling.Roll(5);
            //r11
            bowling.Roll(1);
            
            Assert.Equal(29, bowling.Score());
        }

        [Fact]
        public void TestScoreRound10_PerfectGame()
        {
            Game bowling = new Game();
            // r1 10 + 10 20
            bowling.Roll(10);            
            // r2 
            bowling.Roll(10);            
            // r3 60
            bowling.Roll(10);            
            // r4 80
            bowling.Roll(10);            
            // r5 100
            bowling.Roll(10);            
            //r6 120
            bowling.Roll(10);            
            //r7 140
            bowling.Roll(10);            
            //r8 160
            bowling.Roll(10);
            //r9 180
            bowling.Roll(10);
            //r10 200
            bowling.Roll(10);            
            //r11 210
            bowling.Roll(10);

            Assert.Equal(200, bowling.Score());
        }

        [Fact]
        public void TestScoreRound10_NoBonuses()
        {
            Game bowling = new Game();
            // r1
            bowling.Roll(1);
            bowling.Roll(1);
            // r2
            bowling.Roll(1);
            bowling.Roll(1);
            // r3
            bowling.Roll(1);
            bowling.Roll(1);
            // r4
            bowling.Roll(1);
            bowling.Roll(1);
            // r5
            bowling.Roll(1);
            bowling.Roll(1);
            //r6 
            bowling.Roll(1);
            bowling.Roll(1);
            //r7
            bowling.Roll(1);
            bowling.Roll(1);
            //r8
            bowling.Roll(1);
            bowling.Roll(1);
            //r9
            bowling.Roll(1);
            bowling.Roll(1);
            //r10
            bowling.Roll(1);
            bowling.Roll(1);

            Assert.Equal(20, bowling.Score());
        }

        [Fact]
        public void TestScoreRound10_BonusRound5()
        {
            Game bowling = new Game();
            // r1 2
            bowling.Roll(1);
            bowling.Roll(1);
            // r2 4
            bowling.Roll(1);
            bowling.Roll(1);
            // r3 6
            bowling.Roll(1);
            bowling.Roll(1);
            // r4 8
            bowling.Roll(1);
            bowling.Roll(1);
            // r5 19
            bowling.Roll(10);
            //bowling.Roll(1);
            //r6 21
            bowling.Roll(1);
            bowling.Roll(1);
            //r7 23
            bowling.Roll(1);
            bowling.Roll(1);
            //r8 25
            bowling.Roll(1);
            bowling.Roll(1);
            //r9 27
            bowling.Roll(1);
            bowling.Roll(1);
            //r10 29
            bowling.Roll(1);
            bowling.Roll(1);

            Assert.Equal(29, bowling.Score());
        }
    }
}
