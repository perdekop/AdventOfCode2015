using System;
using NUnit.Framework;
using Perdekop.AdventOfCode2015.Shared;

namespace Perdekop.AdventOfCode2015.Day01.Tests
{
    [TestFixture(Category = "Day 01 - Naive")]
    public class NaiveFloorFinderTests
    {
        #region Private members

        private IFloorFinder _naiveFloorFinder; 

        #endregion

        #region Setup & Teardown

        [SetUp]
        public void Init()
        {
            _naiveFloorFinder = FloorFinderFactory.CreateFloorFinder(ImplementationType.Naive);
        }

        [TearDown]
        public void DeInit()
        {
            _naiveFloorFinder = null;
        }

        #endregion

        #region Negative tests

        [Test]
        public void FindFloor_WithNullString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentNullException>(() => _naiveFloorFinder.FindFloor(null));
        }

        [Test]
        public void FindFloor_WithEmptyString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentNullException>(() => _naiveFloorFinder.FindFloor(string.Empty));
        }

        [Test]
        public void FindFloor_WithWhitespacesString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentException>(() => _naiveFloorFinder.FindFloor(" \r\n\t "));
        }

        [Test]
        public void FindFloor_WithNotOnlyParanthesesString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentException>(() => _naiveFloorFinder.FindFloor("(a)"));
        }

        #endregion

        #region Positive tests

        [Test]
        [TestCase("(", 1)]
        [TestCase(")", -1)]
        [TestCase("((", 2)]
        [TestCase("))", -2)]
        [TestCase("(())", 0)] //description
        [TestCase("()()", 0)] //description
        [TestCase("(((", 3)] //description
        [TestCase("(()(()(", 3)] //description
        [TestCase("))(((((", 3)] //description
        [TestCase("())", -1)] //description
        [TestCase("))(", -1)] //description
        [TestCase(")))", -3)] //description
        [TestCase(")())())", -3)] //description
        [TestCase(")()((((())((())()((()(((())(()))(", 7)]
        public void FindFloor_Logic_Test(string directions, int floor)
        {
            Assert.AreEqual(floor, _naiveFloorFinder.FindFloor(directions));
        }

        #endregion
    }
}
 