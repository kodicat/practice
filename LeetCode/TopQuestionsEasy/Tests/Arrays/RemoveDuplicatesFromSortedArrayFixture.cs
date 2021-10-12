using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using FluentAssertions.Execution;
using NUnit.Framework;

namespace Tests.Arrays
{
	public class RemoveDuplicatesFromSortedArrayFixture
	{
		readonly RemoveDuplicatesFromSortedArray sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] numbers, int[] expectedNumbers)
		{
			var actual = sut.RemoveDuplicates(numbers);

			using (new AssertionScope())
			{
				actual.Should().Be(expectedNumbers.Length);

				for (int i = 0; i < actual; i++)
				{
					numbers[i].Should().Be(expectedNumbers[i]);
				}
			}
		}

		static object[] testCases =
		{
			new object[] { new int[0], new int[0] },
			new object[] { new [] { 1 }, new [] { 1 }},
			new object[] { new [] { 1, 1, 1, 1, 1, 1 }, new [] { 1 } },
			new object[] { new [] { 1, 2, 3, 4 }, new [] { 1, 2, 3, 4} },
			new object[] { new [] { 1, 2, 2, 4 }, new [] { 1, 2, 4} },
			new object[] { new[] { 1, 1, 2, 2, 3, 3, 4, 4 }, new[] { 1, 2, 3, 4 } },
			new object[] { new[] { -1, 0, 1, 2, 2, 3, 3, 4, 4 }, new[] { -1, 0, 1, 2, 3, 4 } }
		};
	}
}