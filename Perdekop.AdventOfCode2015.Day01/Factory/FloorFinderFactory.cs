using Perdekop.AdventOfCode2015.Shared;
using System;

namespace Perdekop.AdventOfCode2015.Day01
{
    public class FloorFinderFactory
    {
        public static IFloorFinder CreateFloorFinder(ImplementationType type)
        {
            switch (type)
            {
                case ImplementationType.Naive: return new NaiveFloorFinder();
                case ImplementationType.Smarter: return new SmarterFloorFinder();
                default: throw new ArgumentException("Unknown implementation type!");
            }
        }
    }
}
