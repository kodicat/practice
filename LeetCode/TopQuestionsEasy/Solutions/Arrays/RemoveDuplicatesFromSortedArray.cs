namespace Arrays.Arrays
{
	public class RemoveDuplicatesFromSortedArray
	{
		public int RemoveDuplicates(int[] nums)
		{
			if (nums.Length < 2)
				return nums.Length;

			int k = 1;
			for (int i = 1; i < nums.Length; i++)
			{
				var isDuplicate = nums[i] == nums[i - 1];

				if (!isDuplicate)
				{
					if (k != i)
						nums[k] = nums[i];

					k++;
				}
			}

			return k;
		}
	}
}