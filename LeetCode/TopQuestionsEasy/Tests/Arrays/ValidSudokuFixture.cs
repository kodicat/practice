using Arrays;
using Arrays.Arrays;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Arrays
{
	[TestFixture]
	public class ValidSudokuFixture
	{
		readonly ValidSudoku sut = new();

		[TestCaseSource(nameof(testCases))]
		public void Test(char[][] board, bool expected)
		{
			var actual = sut.IsValidSudoku(board);

			actual.Should().Be(expected);
		}

		static object[] testCases =
		{
			new object[]
			{
				new []
				{
					new [] { '5','3','.','.','7','.','.','.','.' },
					new [] { '6','.','.','1','9','5','.','.','.' },
					new [] { '.','9','8','.','.','.','.','6','.' },
					new [] { '8','.','.','.','6','.','.','.','3' },
					new [] { '4','.','.','8','.','3','.','.','1' },
					new [] { '7','.','.','.','2','.','.','.','6' },
					new [] { '.','6','.','.','.','.','2','8','.' },
					new [] { '.','.','.','4','1','9','.','.','5' },
					new [] { '.','.','.','.','8','.','.','7','9' }
				},
				true
			}
		};
	}
}
