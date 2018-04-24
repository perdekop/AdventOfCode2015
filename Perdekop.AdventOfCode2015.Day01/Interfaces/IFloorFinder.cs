namespace Perdekop.AdventOfCode2015.Day01
{
    public interface IFloorFinder
    {
        /// <summary>
        /// Determines the final floor, starting at floor 0, based on a string of parantheses.
        /// An opening paranthesis '(' means go up one floor (+1).
        /// A closing paranthesis ')' means go down one floor (-1).
        /// </summary>
        /// <param name="directions">A string containing parantheses.</param>
        /// <returns>The final floor after all parantheses are processed.</returns>
        int FindFloor(string directions);
    }
}
