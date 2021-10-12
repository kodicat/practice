using System;

namespace Solutions.Strings
{
	public class ReverseInteger
	{
		public int Reverse(int x)
		{
			if (x == int.MaxValue || x == int.MinValue)
				return 0;
			var sign = Math.Sign(x);
			var iterator = Math.Abs(x).ToString();

			var result = 0;
			var limit = int.MaxValue / 10;
			for (var i = iterator.Length - 1; i >= 0; i--)
			{
				if (result > limit)
					return 0;

				result *= 10;

				var dec = iterator[i] - '0';
				if (dec > int.MaxValue - result)
					return 0;

				result += dec;
			}

			return result * sign;
		}
	}
}
