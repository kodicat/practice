namespace Solutions.Strings
{
	public class ValidAnagram
	{
		public bool IsAnagram(string s, string t)
		{
			if (s.Length < 2)
				return s == t;
			if (s.Length != t.Length)
				return false;

			var usedChars = new int[26];

			for (int i = 0; i < s.Length; i++)
			{
				usedChars[s[i] - 'a']++;
				usedChars[t[i] - 'a']--;
			}

			for (int i = 0; i < usedChars.Length; i++)
			{
				if (usedChars[i] != 0)
					return false;
			}

			return true;
		}
	}
}
