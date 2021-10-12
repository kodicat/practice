using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class ReverseStringFixture
	{
		readonly ReverseStringSolution sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(char[] s, char[] expected)
		{
			sut.ReverseString(s);

			s.Should().BeEquivalentTo(expected);
		}

		static object[] testCases =
		{
			new object[]
			{
				new [] { 'h','e','l','l','o' },
				new [] { 'o','l','l','e','h' }
			},
			new object[]
			{
				new [] { 'H','a','n','n','a','h' },
				new [] { 'h','a','n','n','a','H' }
			}
		};
	}
}
