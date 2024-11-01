/*
 * 
624. Maximum Distance in Arrays
Medium
Topics
Companies
You are given m arrays, where each array is sorted in ascending order.

You can pick up two integers from two different arrays (each array picks one) and calculate the distance. We define the distance between two integers a and b to be their absolute difference |a - b|.

Return the maximum distance.

 

Example 1:

Input: arrays = [[1,2,3],[4,5],[1,2,3]]
Output: 4
Explanation: One way to reach the maximum distance 4 is to pick 1 in the first or third array and pick 5 in the second array.
Example 2:

Input: arrays = [[1],[1]]
Output: 0
 

Constraints:

m == arrays.length
2 <= m <= 105
1 <= arrays[i].length <= 500
-104 <= arrays[i][j] <= 104
arrays[i] is sorted in ascending order.
There will be at most 105 integers in all the arrays.
 */

namespace LeetCode.Array_String
{
    public class MaximumDistanceInArraysSolution : ILeetCodeProblem
    {
        public int MaxDistance(IList<IList<int>> arrays)
        {
            int max = arrays.First().Last();
            int min = arrays.First().First();
            int result = 0;

            for (int i = 1; i < arrays.Count; i++)
            {
                int currentMin = arrays[i][0];
                int currentMax = arrays[i].Last();

                int maxDiff = Math.Max(Math.Abs(max - currentMin), Math.Abs(currentMax - min));
                result = Math.Max(result, maxDiff);

                max = Math.Max(currentMax, max);
                min = Math.Min(currentMin, min);
            }

            return result;
        }

        // 테스트 케이스 실행 메서드
        public void RunTests()
        {
            var testCases = new List<(IList<IList<int>> arrays, int expected)>
            {
                (new List<IList<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5 }, new List<int> { 1, 2, 3 } }, 4),
                (new List<IList<int>> { new List<int> { 1 }, new List<int> { 1 } }, 0),
                (new List<IList<int>> { new List<int> { 1, 4 }, new List<int> { 0, 5 } }, 4),
                (new List<IList<int>> { new List<int> { -10, -5 }, new List<int> { 0, 5, 10 }, new List<int> { 7, 8 } }, 20),
                (new List<IList<int>> { new List<int> { 0, 0, 0 }, new List<int> { 0, 0, 0 } }, 0),
                (new List<IList<int>> { new List<int> { 1, 3, 7 }, new List<int> { -10, 10 } }, 17),
                (new List<IList<int>> { new List<int> { -100, -50, 0 }, new List<int> { 50, 100 } }, 200)
            };

            Console.WriteLine("Running tests for MaximumDistanceInArrays...");

            foreach (var (arrays, expected) in testCases)
            {
                int result = MaxDistance(arrays);
                Console.WriteLine("Input: {0} | Expected: {1} | Result: {2} | {3}",
                    FormatInput(arrays), expected, result, result == expected ? "Pass" : "Fail");
            }
        }

        private string FormatInput(IList<IList<int>> arrays)
        {
            var formattedArrays = arrays.Select(array => $"[{string.Join(", ", array)}]");
            return $"[{string.Join(", ", formattedArrays)}]";
        }
    }
}
