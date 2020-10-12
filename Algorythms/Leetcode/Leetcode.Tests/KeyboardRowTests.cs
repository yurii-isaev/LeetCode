using Leetcode.KeyboardRow;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class KeyboardRowTests
    {
        private readonly string[] _words = {};
        private readonly string[] _words1 = {"Omk"};
        private readonly string[] _words2 = {"adsdf", "sfd"};
        private readonly string[] _words3 = {"Alaska", "Dad"};
        private readonly string[] _words4 = {"Hello", "Alaska", "Dad", "Peace"};

        [Test]
        public void FindWords1_BasicTests()
        {
            Assert.AreEqual(_words, Solution.FindWords1(_words1));
            Assert.AreEqual(_words2, Solution.FindWords1(_words2));
            Assert.AreEqual(_words3, Solution.FindWords1(_words4));
        }

        [Test]
        public void FindWords2_BasicTests()
        {
            Assert.AreEqual(_words, Solution.FindWords2(_words1));
            Assert.AreEqual(_words2, Solution.FindWords2(_words2));
            Assert.AreEqual(_words3, Solution.FindWords2(_words4));
        }

        [Test]
        public void FindWords3_BasicTests()
        {
            Assert.AreEqual(_words, Solution.FindWords3(_words1));
            Assert.AreEqual(_words2, Solution.FindWords3(_words2));
            Assert.AreEqual(_words3, Solution.FindWords3(_words4));
        }

        [Test]
        public void FindWords4_BasicTests()
        {
            Assert.AreEqual(_words, Solution.FindWords4(_words1));
            Assert.AreEqual(_words2, Solution.FindWords4(_words2));
            Assert.AreEqual(_words3, Solution.FindWords4(_words4));
        }

        [Test]
        public void FindWords5_BasicTests()
        {
            Assert.AreEqual(_words, Solution.FindWords5(_words1));
            Assert.AreEqual(_words2, Solution.FindWords5(_words2));
            Assert.AreEqual(_words3, Solution.FindWords5(_words4));
        }
    }
}
