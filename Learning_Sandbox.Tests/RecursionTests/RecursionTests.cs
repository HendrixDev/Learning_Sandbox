using ClassLibrary1.Recursion;

namespace Learning_Sandbox.Tests.RecursionTests
{
    public class RecursionTests
    {
        [Fact]
        public void RecursiveSumMethod_Returns15()
        {
            //arrange
            int expectedSum = 15;
            int startingSum = 5;

            //act
            int actualSum = Recursion.Sum(startingSum);

            //assert
            Assert.Equal(expectedSum, actualSum);
        }

    }
}
