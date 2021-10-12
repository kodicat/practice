namespace Arrays.Arrays
{
	public class SingleNumberType
	{
		public int SingleNumber(int[] nums)
		{
			var finalNumber = 0;

			for (int i = 0; i < nums.Length; i++)
			{
				finalNumber ^= nums[i];
			}

			return finalNumber;
		}
	}
}