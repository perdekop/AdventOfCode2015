using System;
using System.Linq;

namespace Perdekop.AdventOfCode2015.Day01
{
    public abstract class FloorFinder : IFloorFinder
    {
        public abstract int FindFloor(string directions);

        protected void ValidateInput(string directions)
        {
            if (string.IsNullOrEmpty(directions))
            {
                throw new ArgumentNullException(nameof(directions));
            }

            if (!directions.All(c => c == '(' || c == ')'))
            {
                throw new ArgumentException("Directions may only contain open or closing parantheses!");
            }
        }
    }
}
