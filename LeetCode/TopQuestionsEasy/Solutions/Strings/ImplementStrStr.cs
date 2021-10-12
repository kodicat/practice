namespace Solutions.Strings
{
	public class ImplementStrStr
	{
		public int StrStr(string haystack, string needle)
		{
			if (needle.Length == 0)
				return 0;

			for (var i = 0; i < haystack.Length; i++)
			{
				if (Match(haystack, i, needle))
					return i;
			}

			return -1;
		}

		static bool Match(string haystack, int index, string needle)
		{
			var leftCharacters = haystack.Length - index;
			if (leftCharacters < needle.Length)
				return false;

			for (var i = 0; i < needle.Length; i++)
			{
				if (needle[i] != haystack[i + index])
					return false;
			}

			return true;
		}
	}
}
