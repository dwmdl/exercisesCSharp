// https://leetcode.com/problems/two-sum/

namespace LeetCodeSolution;

public partial class Solution
{
	public static int[] TwoSum(int[] nums, int target)
	{
		for (int i = 0; i < nums.Length; i++)
		{
			for (int j = i + 1; j < nums.Length; j++)
			{
				int sum = nums[i] + nums[j];
				if (sum == target)
				{
					return new int[] { i, j };
				}
			}
		}

		return Array.Empty<int>();
	}
}