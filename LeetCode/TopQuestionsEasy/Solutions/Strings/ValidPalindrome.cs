namespace Solutions.Strings
{
	public class ValidPalindrome
	{
		public bool IsPalindrome(string s)
		{
			if (s.Length < 2)
				return true;

			var startIndex = 0;
			var endIndex = s.Length - 1;
			while (true)
			{
				if (startIndex >= endIndex)
					return true;

				if (!char.IsLetterOrDigit(s[startIndex]))
				{
					startIndex++;
					continue;
				}

				if (!char.IsLetterOrDigit(s[endIndex]))
				{
					endIndex--;
					continue;
				}

				var char1 = ToLower(s[startIndex]);
				var char2 = ToLower(s[endIndex]);

				if (char1 != char2)
					return false;

				startIndex++;
				endIndex--;
			}
		}

		static char ToLower(char c)
		{
			if (c >= 65 && c <= 90)
				return (char) (c | 0b00100000);

			return c;
		}
	}
}
