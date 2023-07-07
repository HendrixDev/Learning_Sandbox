namespace ClassLibrary1.Algorithms
{
    public class DiagonalDifference
    {
        //Given a square matrix, calculate the absolute difference between the sums of its diagonals.
        public int GetDiagonalDifference(List<List<int>> arr)
        {
            int diagonalTotal1 = 0;
            int diagonalTotal2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = 0; j < arr[i].Count; j++)
                {
                    if (i == j)
                        diagonalTotal1 += arr[i][j];

                    if (i + j == arr.Count - 1)
                        diagonalTotal2 += arr[i][j];
                }
            }

            return Math.Abs(diagonalTotal1 - diagonalTotal2);
        }
    }
}
