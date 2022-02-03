using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wordmaster;

namespace WordmasterTest
{
    [TestClass]
    public class UnitTestWordmaster
    {
        [TestMethod]
        public void TestGuessResultBasic()
        {
            GuessResult gr = new GuessResult("tests", "tests");
            GuessResult expected = new GuessResult(new List<LetterResult>() { 
            {new LetterResult(){Letter = 'T', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct } },
            {new LetterResult(){Letter = 'E', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct } },
            {new LetterResult(){Letter = 'S', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct } },
            {new LetterResult(){Letter = 'T', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct } },
            {new LetterResult(){Letter = 'S', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct } } });

            Assert.AreEqual(expected, gr);
            Assert.IsTrue(gr.GameWon);
        }

        [TestMethod]
        public void TestGuessResultGameWon()
        {
            GuessResult gr = new GuessResult("Mansill", "Mansill");
            Assert.IsTrue(gr.GameWon);
        }

        [TestMethod]
        public void TestGuessResultGameLost()
        {
            GuessResult gr = new GuessResult("abcde", "fghij");
            Assert.IsFalse(gr.GameWon);
        }

        [TestMethod]
        public void TestGuessResultGameNotWon()
        {
            GuessResult gr = new GuessResult("abcde", "acdef");
            GuessResult expected = new GuessResult(new List<LetterResult>() {
            {new LetterResult(){Letter = 'A', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct } },
            {new LetterResult(){Letter = 'B', LetterResultEnumValue = LetterResult.LetterResultEnum.Incorrect } },
            {new LetterResult(){Letter = 'C', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct_WrongPosition } },
            {new LetterResult(){Letter = 'D', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct_WrongPosition } },
            {new LetterResult(){Letter = 'E', LetterResultEnumValue = LetterResult.LetterResultEnum.Correct_WrongPosition } } });

            Assert.AreEqual(expected, gr);
        }
    }
}
