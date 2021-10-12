using System.Collections.Generic;
using System.Linq;

namespace Arrays.Arrays
{
	public class IntersectionOfTwoArraysII
	{
		public int[] Intersect(int[] nums1, int[] nums2)
		{
			var smaller = nums1.Length < nums2.Length ? nums1 : nums2;
			var bigger = nums1.Length < nums2.Length ? nums2 : nums1;

			var intersection = new List<int>(smaller.Length);

			foreach (var number in smaller)
			{
				var currentCount = intersection.Sum(x => x == number ? 1 : 0);
				var minExpectedCount = currentCount + 1;

				var actualCount = bigger.Sum(x => x == number ? 1 : 0);

				if (minExpectedCount <= actualCount)
				{
					intersection.Add(number);
				}
			}

			return intersection.ToArray();
		}
	}
}
