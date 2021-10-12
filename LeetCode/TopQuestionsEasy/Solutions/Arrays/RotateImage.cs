namespace Arrays.Arrays
{
	public class RotateImage
	{
		public void Rotate(int[][] matrix)
		{
			var length = matrix.Length;

			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length; j++)
				{
					if (ShouldSwap(length, i, j))
						Swap(matrix, i, j);
				}
			}
		}

		static bool ShouldSwap(int length, int i, int j)
		{
			var maxVectorIndex = length - 1;

			return i >= j && i < maxVectorIndex - j;
		}

		static void Swap(int[][] matrix, int i, int j)
		{
			var currentI = i;
			var currentJ = j;
			var currentValue = matrix[currentI][currentJ];

			for (var k = 0; k < 4; k++)
			{
				var nextI = currentJ;
				var nextJ = matrix.Length - 1 - currentI;
				var nextValue = matrix[nextI][nextJ];

				matrix[nextI][nextJ] = currentValue;

				currentI = nextI;
				currentJ = nextJ;
				currentValue = nextValue;
			}
		}
	}
}
