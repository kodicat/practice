using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	[TestFixture]
	public class ContainsDuplicateFixture
	{
		readonly ContainsDuplicateType sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] numbers, bool contains)
		{
			var actual = sut.ContainsDuplicate(numbers);

			actual.Should().Be(contains);
		}

		static object[] testCases =
		{
			new object[] { new int[0], false },
			new object[] { new [] { 1 }, false },
			new object[] { new [] { 1, 2, 3, 1 }, true },
			new object[] { new [] { 1, 2, 3, 4 }, false },
			new object[] { new [] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true }
		};
	}
}
