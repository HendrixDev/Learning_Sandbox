using Learning.Algorithms;

namespace Learning_Sandbox.Tests.AlgorithmTests
{
    public class BuyTwoChocolateTests
    {
        private readonly BuyTwoChocolates _buyTwoChocolates = new();

        [Fact]
        public void BuyTwoChocolates_Returns_3()
        {
            //arrange
            int[] prices = new int[3] { 3,2,3 };
            int money = 3;
            int expectedResult = 3;

            //act
            int actualResult = _buyTwoChocolates.BuyChoco(prices, money);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void BuyTwoChocolates_Returns_0()
        {
            //arrange
            int[] prices = new int[3] { 1, 2, 2 };
            int money = 3;
            int expectedResult = 0;

            //act
            int actualResult = _buyTwoChocolates.BuyChoco(prices, money);

            //assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
