using Learning.Algorithms;

namespace Learning_Sandbox.Tests.AlgorithmTests
{
    public class ReverseIntegerTests
    {
        private readonly ReverseInteger _reverseInteger = new();

        [Fact]
        public void ReverseInteger_Returns_654321()
        {
            //arrange
            int intToReverse = 123456;
            int expectedResult = 654321;

            //act
            int actualResult = _reverseInteger.Reverse(intToReverse);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ReverseInteger_Returns_96369()
        {
            //arrange
            int intToReverse = 96369;
            int expectedResult = 96369;

            //act
            int actualResult = _reverseInteger.Reverse(intToReverse);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ReverseInteger_Returns_Negative_321()
        {
            //arrange
            int intToReverse = -123;
            int expectedResult = -321;

            //act
            int actualResult = _reverseInteger.Reverse(intToReverse);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ReverseInteger_Returns_Negative_999()
        {
            //arrange
            int intToReverse = -999;
            int expectedResult = -999;

            //act
            int actualResult = _reverseInteger.Reverse(intToReverse);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ReverseInteger_Returns_21()
        {
            //arrange
            int intToReverse = 120;
            int expectedResult = 21;

            //act
            int actualResult = _reverseInteger.Reverse(intToReverse);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ReverseInteger_Returns_55()
        {
            //arrange
            int intToReverse = 550;
            int expectedResult = 55;

            //act
            int actualResult = _reverseInteger.Reverse(intToReverse);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
