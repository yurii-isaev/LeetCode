using Leetcode.AssignCookies;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class AssignCookiesTests
    {
        private readonly int[] _list  = new int[0];
        private readonly int[] _list1 = new[] {1, 2, 3};
        private readonly int[] _list2 = new[] {1, 1};
        private readonly int[] _list3 = new[] {1, 2};

        [Test]
        public void FindContentChildren_BasicTests()
        {
            Assert.AreEqual(0, Solution.FindContentChildren(_list, _list));
            Assert.AreEqual(1, Solution.FindContentChildren(_list1, _list2));
            Assert.AreEqual(2, Solution.FindContentChildren(_list3, _list1));
        }
    }
}
