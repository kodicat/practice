using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	[TestFixture]
	public class PlusOneFixture
	{
		readonly PlusOneType sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] digits, int[] expected)
		{
			var actual = sut.PlusOne(digits);

			actual.Should().BeEquivalentTo(expected);
		}

		static object[] testCases =
		{
			new object[] { new [] { 1, 2, 3 }, new [] { 1, 2, 4 } },
			new object[] { new [] { 4, 3, 2, 1 }, new [] { 4, 3, 2, 2 } },
			new object[] { new [] { 0 }, new [] { 1 } },
			new object[] { new [] { 9 }, new [] { 1, 0 } },
			new object[] { new [] { 9, 9, 9 }, new [] { 1, 0, 0, 0 } }
		};
	}
}
