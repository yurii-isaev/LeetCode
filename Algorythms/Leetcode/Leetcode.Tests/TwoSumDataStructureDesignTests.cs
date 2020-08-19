using Leetcode.TwoSumDataStructureDesign;
using NUnit.Framework;

namespace Leetcode.Tests
{
    [TestFixture]
    public class TwoSumDataStructureDesignTests
    {
        [SetUp]
        public void Setup()
        {
            DictionarySolution.Add(1);
            DictionarySolution.Add(3);
            DictionarySolution.Add(5);
            SetSolution.Add(1);
            SetSolution.Add(3);
            SetSolution.Add(5);
        }

        [Test]
        public void DictionarySolution_IsFind1_BasicTests()
        {
            Assert.AreEqual(false, DictionarySolution.IsFind1(0));
            Assert.AreEqual(false, DictionarySolution.IsFind1(1));
            Assert.AreEqual(true, DictionarySolution.IsFind1(4));
            Assert.AreEqual(false, DictionarySolution.IsFind1(7));
            Assert.AreEqual(true, DictionarySolution.IsFind1(8));
        }

        [Test]
        public void DictionarySolution_IsFind2_BasicTests()
        {
            Assert.AreEqual(false, DictionarySolution.IsFind2(0));
            Assert.AreEqual(false, DictionarySolution.IsFind2(1));
            Assert.AreEqual(true, DictionarySolution.IsFind2(4));
            Assert.AreEqual(false, DictionarySolution.IsFind2(7));
            Assert.AreEqual(true, DictionarySolution.IsFind2(8));
        }
        
        [Test]
        public void SetSolution_IsFind_BasicTests()
        {
            Assert.AreEqual(false, SetSolution.IsFind(0));
            Assert.AreEqual(false, SetSolution.IsFind(1));
            Assert.AreEqual(true, SetSolution.IsFind(4));
            Assert.AreEqual(false, SetSolution.IsFind(7));
            Assert.AreEqual(true, SetSolution.IsFind(8));
        }
    }
}
