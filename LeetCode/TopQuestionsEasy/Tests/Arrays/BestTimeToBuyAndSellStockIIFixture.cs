using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	public class BestTimeToBuyAndSellStockIIFixture
	{
		readonly BestTimeToBuyAndSellStockII sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] numbers, int expectedMaxProfit)
		{
			var actual = sut.MaxProfit(numbers);

			actual.Should().Be(expectedMaxProfit);
		}

		static object[] testCases =
		{
			new object[] { new int[0], 0 },
			new object[] { new [] { 1 }, 0},
			new object[] { new [] { 1, 1, 1, 1, 1, 1 }, 0 },
			new object[] { new [] { 1, 2, 3, 4 }, 3 },
			new object[] { new [] { 1, 2, 2, 4 }, 3 },
			new object[] { new[] { 1, 1, 2, 2, 3, 3, 4, 4 }, 3 },
			new object[] { new[] { 0, 1, 2, 2, 3, 3, 4, 4 }, 4 },
			new object[] { new[] { 0, 1, 5, 1, 3, 8, 4, 4 }, 12 },
			new object[] { new[] { 0, 1, 8, 2, 3, 3, 4, 4 }, 10 }
		};
	}
}
