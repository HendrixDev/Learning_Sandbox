using Learning.Algorithms;

namespace Learning_Sandbox.Tests.AlgorithmTests
{

    public class DivisibleSumPairTests
    {
        private readonly DivisibleSumPairs _divisibleSumPairs = new();

        [Fact]
        public void GetTotalDivisableSumPairs_Returns_5()
        {
            //arrange
            int divisor = 3;
            List<int> ar = new() { 1, 3, 2, 6, 1, 2 };

            int expectedSumPairs = 5;

            //act
            int actualSumPairs = _divisibleSumPairs.GetTotalDivisableSumPairs(divisor, ar);

            //assert
            Assert.Equal(expectedSumPairs, actualSumPairs);
        }

        [Fact]
        public void GetTotalDivisableSumPairs_Returns_3()
        {
            //arrange
            int divisor = 3;
            List<int> ar = new() { 2, 8, 6, 8, 4 };

            int expectedSumPairs = 3;

            //act
            int actualSumPairs = _divisibleSumPairs.GetTotalDivisableSumPairs(divisor, ar);

            //assert
            Assert.Equal(expectedSumPairs, actualSumPairs);
        }

        [Fact]
        public void GetTotalDivisableSumPairs_Returns_4()
        {
            //arrange
            int divisor = 2;
            List<int> ar = new() { 5, 9, 10, 7, 4 };

            int expectedSumPairs = 4;

            //act
            int actualSumPairs = _divisibleSumPairs.GetTotalDivisableSumPairs(divisor, ar);

            //assert
            Assert.Equal(expectedSumPairs, actualSumPairs);
        }

    }
}
