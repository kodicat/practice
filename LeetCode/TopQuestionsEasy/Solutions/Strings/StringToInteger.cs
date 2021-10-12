namespace Solutions.Strings
{
	public class StringToInteger
	{
		public int MyAtoi(string s)
		{
			var index = 0;

			for (; index < s.Length; index++)
				if (s[index] != ' ')
					break;

			var sign = 1;
			if (index < s.Length && IsSign(s[index]))
			{
				sign = s[index] == '-' ? -1 : 1;
				index++;
			}

			var number = 0;
			const int limit = int.MaxValue / 10;

			for (; index < s.Length && IsDigit(s[index]); index++)
			{
				if (number > limit)
					return sign == 1 ? int.MaxValue : int.MinValue;

				var c = s[index] - '0';
				number *= 10;

				if (c > int.MaxValue - number)
					return sign == 1 ? int.MaxValue : int.MinValue;

				number += c;
			}

			return number * sign;
		}

		static bool IsSign(char c)
		{
			return c == '-' || c == '+';
		}

		static bool IsDigit(char c)
		{
			return c >= 48 && c <= 57;
		}
	}
}
