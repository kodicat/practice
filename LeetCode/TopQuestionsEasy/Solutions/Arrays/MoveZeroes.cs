namespace Arrays.Arrays
{
	public class MoveZeroesType
	{
		public void MoveZeroes(int[] nums)
		{
			if (nums.Length < 2)
				return;

			var nonZeroIndex = 0;
			for (int i = 0; i < nums.Length; i++)
			{
				if (nums[i] != 0)
				{
					nums[nonZeroIndex] = nums[i];
					nonZeroIndex++;
				}
			}

			for (int i = nonZeroIndex; i < nums.Length; i++)
			{
				nums[i] = 0;
			}
		}
	}
}
