using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class StringToIntegerFixture
	{
		readonly StringToInteger sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(string s, int expected)
		{
			var actual = sut.MyAtoi(s);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[] { "   -42", -42 },
			new object[] { "42", 42 },
			new object[] { "42.00", 42 },
			new object[] { "0042", 42 },
			new object[] { " ", 0 },
			new object[] { "+-", 0 },
			new object[] { "-+", 0 },
			new object[] { "-+42", 0 },
			new object[] { "", 0 },
			new object[] { "....", 0 },
			new object[] { "-", 0 },
			new object[] { "words and 987", 0 },
			new object[] { "-2147483647", -2147483647 },
			new object[] { "-2147483648", -2147483648 },
			new object[] { "-2147483649", -2147483648 },
			new object[] { "-91283472332", -2147483648 },
			new object[] { "2147483646", 2147483646 },
			new object[] { "999999999999999999999", 2147483647 }
		};
	}
}
