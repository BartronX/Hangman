using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangmanGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Tests
{
    [TestClass()]
    public class RulesTests
    {
        [TestMethod()]
        public void isALetter_TestForLowercase()
        {
            char input = 'a';

            Assert.IsTrue(Rules.IsALetter(input));
        }

        [TestMethod()]
        public void isALetter_TestForUppercase()
        {
            char input = 'A';

            Assert.IsTrue(Rules.IsALetter(input));
        }

        [TestMethod()]
        public void isALetter_TestForNumber()
        {
            char input = '5';

            Assert.IsFalse(Rules.IsALetter(input));
        }

        [TestMethod()]
        public void isALetter_TestForSpecialCharacter()
        {
            char input = '@';

            Assert.IsFalse(Rules.IsALetter(input));
        }

        [TestMethod()]
        public void letterContains_TestForMatchingLowercaseLetter()
        {
            string word = "Animal";
            char input = 'a';

            Assert.IsTrue(Rules.WordContains(word, input));
        }

        [TestMethod()]
        public void letterContains_TestForMatchingUpperLetter()
        {
            string word = "Animal";
            char input = 'M';

            Assert.IsTrue(Rules.WordContains(word, input));
        }

        [TestMethod()]
        public void letterContains_TestForNonMatchingInput()
        {
            string word = "Animal";
            char input = '4';

            Assert.IsFalse(Rules.WordContains(word, input));
        }

        [TestMethod()]
        public void OutOfAttempts_TestNoMoreAttempts()
        {
            int attempts = 7;

            Assert.IsTrue(Rules.OutOfAttempts(attempts));
        }

        [TestMethod()]
        public void OutOfAttempts_TestHasMoreAttempts()
        {
            int attempts = 6;

            Assert.IsFalse(Rules.OutOfAttempts(attempts));
        }
    }
}