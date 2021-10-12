using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	[TestFixture]
	public class TwoSumFixture
	{
		readonly TwoSumSolution sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] numbers, int target, int[] expected)
		{
			var actual = sut.TwoSum(numbers, target);

			actual.Should().BeEquivalentTo(expected);
		}

		static object[] testCases =
		{
			new object[] { new [] { 2, 7, 11, 15 }, 9, new [] {0, 1} },
			new object[] { new [] { 3, 2, 4 }, 6, new [] {1, 2}},
			new object[] { new [] { 3, 3 }, 6, new [] {0, 1} },
			new object[] { new [] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new [] {5, 11} }
		};
	}
}
