using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	public class SingleNumberFixture
	{
		readonly SingleNumberType sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] numbers, int expectedNumber)
		{
			var actual = sut.SingleNumber(numbers);

			actual.Should().Be(expectedNumber);
		}

		static object[] testCases =
		{
			new object[] { new [] { 1 }, 1 },
			new object[] { new [] { 2, 2, 1 }, 1 },
			new object[] { new [] { 4, 1, 2, 1, 2 }, 4 },
			new object[] { new [] { 4, 1, 2, 1, 2, 4, 5 }, 5 }
		};
	}
}
