using System.Collections.Generic;

namespace Arrays.Arrays
{
	public class TwoSumSolution
	{
		public int[] TwoSum(int[] nums, int target)
		{
			if (nums.Length < 3)
				return new[] {0, 1};

			var visited = new Dictionary<int, int>();

			for (int i = 0; i < nums.Length; i++)
			{
				var complement = target - nums[i];
				if (visited.ContainsKey(complement))
					return new[] { visited[complement], i };

				visited[nums[i]] = i;
			}

			return null;
		}
	}
}
