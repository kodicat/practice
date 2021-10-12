namespace Arrays.Arrays
{
	public class RotateArray
	{
		public void Rotate(int[] nums, int k)
		{
			var len = nums.Length;
			var shift = k % len;

			if (nums.Length < 2 || shift == 0)
				return;

			var gcd = CalculateGCD(shift, len);

			for (var i = 0; i < gcd; i++)
			{
				var currentIndex = i;
				var currentValue = nums[currentIndex];

				for (var j = 0; j < len / gcd; j++)
				{
					var nextIndex = (currentIndex + shift) % len;

					var nextValue = nums[nextIndex];

					nums[nextIndex] = currentValue;
					currentIndex = nextIndex;
					currentValue = nextValue;
				}
			}
		}

		static int CalculateGCD(int a, int b)
		{
			if (a == 1 || b == 1)
				return 1;

			while (true)
			{
				if (a == b)
					return a;

				if (a > b)
				{
					a -= b;
				}
				else
				{
					b -= a;
				}
			}
		}
	}
}