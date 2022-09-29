// https://leetcode.com/problems/running-sum-of-1d-array/

namespace LeetCodeSolution;

public partial class Solution
{
	public static int[] RunningSum(int[] nums)
	{
		var sum = 0;
		var array = new int[nums.Length];
		for (var i = 0; i < nums.Length; i++)
		{
			sum += nums[i];
			array[i] = sum;
		}

		return array;
	}
}