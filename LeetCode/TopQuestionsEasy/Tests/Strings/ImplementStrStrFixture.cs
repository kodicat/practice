using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class ImplementStrStrFixture
	{
		readonly ImplementStrStr sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(string haystack, string needle, int expected)
		{
			var actual = sut.StrStr(haystack, needle);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[] { "hello", "ll", 2 },
			new object[] { "aaaaa", "bba", -1},
			new object[] { "", "", 0},
			new object[] { "abcd", "cde", -1},
			new object[] { "abcd", "cd", 2},
			new object[] { "abcd", "bd", -1}
		};
	}
}
