using System.Collections.Generic;
using Leetcode.ValidWordSquare;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class ValidWordSquareTests
    {
        private readonly List<string> _list  = new List<string> ();
        private readonly List<string> _list1 = new List<string> {"abcd", "bnrt", "crmy", "dtye"};
        private readonly List<string> _list2 = new List<string> {"abcd", "bnrt", "crm", "dt"};
        private readonly List<string> _list3 = new List<string> {"ball", "area", "read", "lady"};

        [Test]
        public void IsValidWordSquare_BasicTests()
        {
            Assert.AreEqual(true, Solution.IsValidWordSquare(_list));
            Assert.AreEqual(true, Solution.IsValidWordSquare(_list1));
            Assert.AreEqual(true, Solution.IsValidWordSquare(_list2));
            Assert.AreEqual(false, Solution.IsValidWordSquare(_list3));
        }

        [Test]
        public void IsValidWordSquareByStringBuilder_BasicTests()
        {
            Assert.AreEqual(true, Solution.IsValidWordSquareByStringBuilder(_list));
            Assert.AreEqual(true, Solution.IsValidWordSquareByStringBuilder(_list1));
            Assert.AreEqual(true, Solution.IsValidWordSquareByStringBuilder(_list2));
            Assert.AreEqual(false, Solution.IsValidWordSquareByStringBuilder(_list3));
        }
    }
}
