using System;
using System.Collections.Generic;

namespace Arrays.Arrays
{
	public class ValidSudoku
	{
		public bool IsValidSudoku(char[][] board)
		{
			for (int i = 0; i < 9; i++)
			{
				var index = i;

				var validRow = IsValidSequence(board, x => x == index, _ => true);
				var validColumn = IsValidSequence(board, _ => true, x => x == index);

				var sectorRowIndexStart = (index % 3) * 3;
				var sectorColumnIndexStart = (index / 3) * 3;
				var validSector = IsValidSequence(
					board,
					x => x >= sectorRowIndexStart && x <= sectorRowIndexStart + 2,
					x => x >= sectorColumnIndexStart && x <= sectorColumnIndexStart + 2);

				if (!validRow || !validColumn || !validSector)
					return false;
			}

			return true;
		}

		static bool IsValidSequence(char[][] sequence, Func<int, bool> rowPredicate, Func<int, bool> columnPredicate)
		{
			var set = new HashSet<char>();

			for (int rowIndex = 0; rowIndex < 9; rowIndex++)
			{
				if (rowPredicate(rowIndex))
				{
					for (int columnIndex = 0; columnIndex < 9; columnIndex++)
					{
						if (columnPredicate(columnIndex))
						{
							var currentValue = sequence[rowIndex][columnIndex];
							if (currentValue != '.')
							{
								if (set.Contains(currentValue))
									return false;

								set.Add(currentValue);
							}
						}
					}
				}
			}

			return true;
		}
	}
}
