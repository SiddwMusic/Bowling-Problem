using Bowling_Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingTest
{
    [TestClass]
    public class UnitTest1
    {
        private Bowling game;

        [TestInitialize]
        public void initClass()
        {
            game = new Bowling();
        }

        [TestMethod]
        public void TestBowlingOnes()
        {
            rollMany(20, 1);
            Assert.AreEqual(20, game.calculateScore());
        }

        [TestMethod]
        public void TestBowlingSpare()
        { 
            game.roll(3);
            game.roll(7);
            game.roll(4);
            rollMany(17, 0);
            Assert.AreEqual(18, game.calculateScore());
        }

        [TestMethod]
        public void TestBowlingStrike()
        {
            game.roll(10);
            game.roll(4);
            game.roll(5);
            rollMany(17, 0);
            Assert.AreEqual(28, game.calculateScore());
        }


        private void rollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                game.roll(pins);
            }
        }
    }

    
}
