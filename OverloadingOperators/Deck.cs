namespace OverloadingOperators
{
    public class Deck
    {
        public string Type { get; set; }
        public int NumberOfCards { get; set; }

        public Deck(string type, int numberOfCards)
        {
            Type = type;
            NumberOfCards = numberOfCards;
        }

        //Overloading the + operator to add 2 deck objects together
        public static Deck operator +(Deck deck1, Deck deck2)
        {
            string types = $"{deck1.Type}, {deck2.Type}";
            int newNumberOfCards = deck1.NumberOfCards + deck2.NumberOfCards;
            return new Deck(types, newNumberOfCards);
        }

        public override string ToString()
        {
            return $"Deck type: {Type} \n" +
                   $"Number of cards: {NumberOfCards} \n\n";
        }
    }
}
