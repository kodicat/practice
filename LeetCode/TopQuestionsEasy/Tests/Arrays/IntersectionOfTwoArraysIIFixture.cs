using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	[TestFixture]
	public class IntersectionOfTwoArraysIIFixture
	{
		readonly IntersectionOfTwoArraysII sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(int[] nums1, int[] nums2, int[] expected)
		{
			var actual = sut.Intersect(nums1, nums2);

			actual.Should().BeEquivalentTo(expected);
		}

		static object[] testCases =
		{
			new object[] { new [] { 1, 2, 2, 1 }, new [] { 2, 2 }, new [] { 2, 2 } },
			new object[] { new [] { 4, 9, 5 }, new [] { 9, 4, 9, 8, 4 }, new [] { 4, 9 } }
		};
	}
}
