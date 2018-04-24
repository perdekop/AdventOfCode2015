using System.Linq;

namespace Perdekop.AdventOfCode2015.Day01
{
    public class SmarterFloorFinder : FloorFinder, IFloorFinder
    {
        public override int FindFloor(string directions)
        {
            base.ValidateInput(directions);

            //just substract the number of 'ups' and the number of 'downs'
            var upCount = directions.Count(c => c == '(');
            var downCount = directions.Count(c => c == ')');

            return upCount - downCount;
        }
    }
}
