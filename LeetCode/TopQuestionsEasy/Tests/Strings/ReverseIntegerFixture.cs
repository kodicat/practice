using FluentAssertions;
using NUnit.Framework;
using Solutions.Strings;

namespace Tests.Strings
{
	[TestFixture]
	public class ReverseIntegerFixture
	{
		readonly ReverseInteger sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int x, int expected)
		{
			var actual = sut.Reverse(x);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[] { 123, 321 },
			new object[] { -123, -321},
			new object[] { 120, 21},
			new object[] { 0, 0 },
			new object[] { int.MaxValue, 0},
			new object[] { int.MinValue, 0}
		};
	}
}
