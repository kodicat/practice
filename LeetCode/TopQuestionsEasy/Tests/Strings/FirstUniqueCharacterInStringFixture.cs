using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class FirstUniqueCharacterInStringFixture
	{
		readonly FirstUniqueCharacterInString sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(string s, int expected)
		{
			var actual = sut.FirstUniqChar(s);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[] { "leetcode", 0 },
			new object[] { "loveleetcode", 2 },
			new object[] { "aabb", -1 }
		};
	}
}
