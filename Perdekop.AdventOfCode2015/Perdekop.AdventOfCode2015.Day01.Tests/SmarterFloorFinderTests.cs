using NUnit.Framework;
using Perdekop.AdventOfCode2015.Shared;
using System;

namespace Perdekop.AdventOfCode2015.Day01.Tests
{
    [TestFixture(Category = "Day 01 - Smarter")]
    public class SmarterFloorFinderTests
    {
        #region Private members

        private IFloorFinder _smarterFloorFinder;

        #endregion

        #region Setup & Teardown

        [SetUp]
        public void Init()
        {
            _smarterFloorFinder = FloorFinderFactory.CreateFloorFinder(ImplementationType.Smarter);
        }

        [TearDown]
        public void DeInit()
        {
            _smarterFloorFinder = null;
        }

        #endregion

        #region Negative tests

        [Test]
        public void FindFloor_WithNullString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentNullException>(() => _smarterFloorFinder.FindFloor(null));
        }

        [Test]
        public void FindFloor_WithEmptyString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentNullException>(() => _smarterFloorFinder.FindFloor(string.Empty));
        }

        [Test]
        public void FindFloor_WithWhitespacesString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentException>(() => _smarterFloorFinder.FindFloor(" \r\n\t "));
        }

        [Test]
        public void FindFloor_WithNotOnlyParanthesesString_ShouldRaiseException_Test()
        {
            Assert.Throws<ArgumentException>(() => _smarterFloorFinder.FindFloor("(a)"));
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
            Assert.AreEqual(floor, _smarterFloorFinder.FindFloor(directions));
        }

        #endregion
    }
}
