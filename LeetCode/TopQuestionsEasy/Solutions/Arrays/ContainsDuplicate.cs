using System.Collections.Generic;

namespace Arrays.Arrays
{
	public class ContainsDuplicateType
	{
		public bool ContainsDuplicate(int[] nums)
		{
			if (nums.Length < 2)
				return false;

			var uniqueValues = new HashSet<int>();

			foreach (var num in nums)
			{
				if (uniqueValues.Contains(num))
					return true;

				uniqueValues.Add(num);
			}

			return false;
		}
	}
}
