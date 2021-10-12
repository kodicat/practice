namespace Arrays.Arrays
{
	public class PlusOneType
	{
		public int[] PlusOne(int[] digits)
		{
			var shouldIncreaseLength = false;
			for (var i = digits.Length - 1; i >= 0; i--)
			{
				var newDigit = (digits[i] + 1) % 10;

				digits[i] = newDigit;

				if (newDigit != 0)
					break;

				if (i == 0)
					shouldIncreaseLength = true;
			}

			if (!shouldIncreaseLength)
				return digits;

			var result = new int[digits.Length + 1];
			result[0] = 1;
			return result;
		}
	}
}
