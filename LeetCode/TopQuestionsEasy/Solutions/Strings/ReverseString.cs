namespace Solutions.Strings
{
	public class ReverseStringSolution
	{
		public void ReverseString(char[] s)
		{
			for (var i = 0; i < s.Length / 2; i++)
			{
				var swap = s[i];
				s[i] = s[s.Length - 1 - i];
				s[s.Length - 1 - i] = swap;
			}
		}
	}
}
