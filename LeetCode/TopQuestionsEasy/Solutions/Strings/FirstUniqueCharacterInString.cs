namespace Solutions.Strings
{
	public class FirstUniqueCharacterInString
	{
		public int FirstUniqChar(string s)
		{
			var usedCharacters = new int[26];

			for (int i = s.Length - 1; i >= 0; i--)
			{
				usedCharacters[s[i] - 'a']++;
			}

			for (int i = 0; i < s.Length; i++)
			{
				if (usedCharacters[s[i] - 'a'] == 1)
					return i;
			}

			return -1;
		}
	}
}
