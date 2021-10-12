using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class ValidPalindromeFixture
	{
		readonly ValidPalindrome sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(string s, bool expected)
		{
			var actual = sut.IsPalindrome(s);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[] { "A man, a plan, a canal: Panama", true },
			new object[] { "race a car", false },
			new object[] { "", true },
			new object[] { " ", true },
			new object[] { ".,", true }
		};
	}
}
