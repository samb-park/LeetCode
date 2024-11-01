﻿/*
 * 
 * https://leetcode.com/problems/wiggle-sort/description/?envType=study-plan-v2&envId=premium-algo-100
 * 280. Wiggle Sort
Medium
Topics
Companies
Given an integer array nums, reorder it such that nums[0] <= nums[1] >= nums[2] <= nums[3]....

You may assume the input array always has a valid answer.

 

Example 1:

Input: nums = [3,5,2,1,6,4]
Output: [3,5,1,6,2,4]
Explanation: [1,6,2,5,3,4] is also accepted.
Example 2:

Input: nums = [6,6,5,6,3,8]
Output: [6,6,5,6,3,8]
 

Constraints:

1 <= nums.length <= 5 * 104
0 <= nums[i] <= 104
It is guaranteed that there will be an answer for the given input nums.
 

Follow up: Could you solve the problem in O(n) time complexity?
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Array_String
{
    public class WiggleSortSolution : ILeetCodeProblem
    {
        public void RunTests()
        {
            var testCase = new int[] { 3, 5, 2, 1, 6, 4 };

            WiggleSort(testCase);

            foreach (var num in testCase)
            {
                Console.WriteLine(num + ", ");

            }
        }

        public void WiggleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if( i % 2 == 0 && !(nums[i] <= nums[i+1])
                    ||
                    i % 2 == 1 && !(nums[i] >= nums[i + 1]))
                {
                    var temp = nums[i];
                    nums[i] = nums[i+1];
                    nums[i+1] = temp;
                }
            }

        }
    }
}
