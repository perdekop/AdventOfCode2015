using System;

namespace Perdekop.AdventOfCode2015.Day01
{
    public class NaiveFloorFinder : FloorFinder, IFloorFinder
    {
        public override int FindFloor(string directions)
        {
            base.ValidateInput(directions);

            var currentFloor = 0;

            //check each parenthesis and in- or decrease a temporary counter accordingly
            for (var i = 0; i < directions.Length; i++)
            {
                switch (directions[i])
                {
                    case '(':  currentFloor += 1; break;
                    case ')': currentFloor -= 1; break;
                    default: throw new ArgumentException($"Invalid character encountered at position {i}!");
                }
            }

            return currentFloor;
        }
    }
}
