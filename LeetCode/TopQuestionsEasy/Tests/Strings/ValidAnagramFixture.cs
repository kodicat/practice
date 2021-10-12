using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class ValidAnagramFixture
	{
		readonly ValidAnagram sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(string s, string t, bool expected)
		{
			var actual = sut.IsAnagram(s, t);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[] { "anagram", "nagaram", true },
			new object[] { "rat", "car", false }
		};
	}
}
