namespace Perdekop.AdventOfCode2015.Day01
{
    public abstract class FloorFinder : IFloorFinder
    {
        public abstract int FindFloor(string directions);

        protected void ValidateInput(string directions)
        {
            ;
        }
    }
}
