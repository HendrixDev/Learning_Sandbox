using OverloadingOperators;

namespace Learning_Sandbox.Tests.OverloadingOperatorsTests
{
    public class OverloadingDeckTests
    {
        [Fact]
        public void AddingTwoDecks_Returns_2Types_60Cards()
        {
            //arrange
            Deck deck1 = new("Fire", 30);
            Deck deck2 = new("Water", 30);

            //act
            Deck newDeck = deck1 + deck2;

            //assert
            Assert.Equal("Fire, Water", newDeck.Type);
            Assert.Equal(60, newDeck.NumberOfCards);
        }

        [Fact]
        public void AddingTwoDecks_Returns_2Types_90Cards()
        {
            //arrange
            Deck deck1 = new("Grass", 30);
            Deck deck2 = new("Steel", 60);

            //act
            Deck newDeck = deck1 + deck2;

            //assert
            Assert.Equal("Grass, Steel", newDeck.Type);
            Assert.Equal(90, newDeck.NumberOfCards);
        }
    }
}
