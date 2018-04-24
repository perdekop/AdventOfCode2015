using NUnit.Framework;

namespace Perdekop.AdventOfCode2015.Day01.Tests
{
    [TestFixture(Category = "Day 01 - Factory")]
    public class FloorFinderFactoryTests
    {
        [Test]
        public void FloorFinderFactory_CreateNaiveFloorFinderSuccess_Test()
        {
            var floorFinder = FloorFinderFactory.CreateFloorFinder(Shared.ImplementationType.Naive);

            Assert.IsInstanceOf<NaiveFloorFinder>(floorFinder);
        }

        [Test]
        public void FloorFinderFactory_CreateSmarterFloorFinderSuccess_Test()
        {
            var floorFinder = FloorFinderFactory.CreateFloorFinder(Shared.ImplementationType.Smarter);

            Assert.IsInstanceOf<SmarterFloorFinder>(floorFinder);
        }
    }
}
