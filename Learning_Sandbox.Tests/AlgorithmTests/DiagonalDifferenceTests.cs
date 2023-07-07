using ClassLibrary1.Algorithms;

namespace Learning_Sandbox.Tests.AlgorithmTests
{
    public class DiagonalDifferenceTests
    {
        private readonly DiagonalDifference _diagonalDifference = new();

        [Fact]
        public void GetDiagonalDifference_Returns15()
        {
            //arrange
            int expectedDifference = 15;

            List<List<int>> array = new()
            {
                new List<int> { 11, 2, 4 },
                new List<int> { 4, 5, 6 },
                new List<int> { 10, 8, -12 }
            };

            //act
            int actualDifference = _diagonalDifference.GetDiagonalDifference(array);

            //assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void GetDiagonalDifference_Returns1()
        {
            //arrange
            int expectedDifference = 1;

            List<List<int>> array = new()
            {
                new List<int> {-1, 1, -7, -8},
                new List<int> {-10, -8, -5, -2},
                new List<int> {0, 9, 7, -1},
                new List<int> {4, 4, -2, 1, }
            };

            //act
            int actualDifference = _diagonalDifference.GetDiagonalDifference(array);

            //assert
            Assert.Equal(expectedDifference, actualDifference);
        }

        [Fact]
        public void GetDiagonalDifference_Returns52()
        {
            //arrange
            int expectedDifference = 52;

            List<List<int>> array = new()
            {
                new List<int> {6, 6, 7, -10, 9, -3, 8, 9, -1 },
                new List<int> {9, 7, -10, 6, 4, 1, 6, 1, 1 },
                new List<int> {-1, -2, 4, -6, 1, -4, -6, 3, 9 },
                new List<int> {-8, 7, 6, -1, -6, -6, 6, -7, 2 },
                new List<int> {-10, -4, 9, 1, -7, 8, -5, 3, -5 },
                new List<int> {-8, -3, -4, 2, -3, 7, -5, 1, -5 },
                new List<int> {-2, -7, -4, 8, 3, -1, 8, 2, 3 },
                new List<int> {-3, 4, 6, -7, -7, -8, -3, 9, -6 },
                new List<int> {-2, 0, 5, 4, 4, 4, -3, 3, 0 }
            };

            //act
            int actualDifference = _diagonalDifference.GetDiagonalDifference(array);

            //assert
            Assert.Equal(expectedDifference, actualDifference);
        }
    }
}
