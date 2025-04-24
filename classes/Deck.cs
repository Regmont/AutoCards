using System.Collections.Generic;

namespace AutoCards
{
    public class Deck
    {
        public List<Card> Cards_1 { get; set; }
        public List<Card> Cards_2 { get; set; }
        public List<Card> Cards_3 { get; set; }
        public List<Card> Cards_4 { get; set; }
        public List<Card> Cards_5 { get; set; }
        public List<Card> Cards_6 { get; set; }

        public Deck(
            List<Card> cards_1, List<Card> cards_2,
            List<Card> cards_3, List<Card> cards_4,
            List<Card> cards_5, List<Card> cards_6)
        {
            Cards_1 = cards_1;
            Cards_2 = cards_2;
            Cards_3 = cards_3;
            Cards_4 = cards_4;
            Cards_5 = cards_5;
            Cards_6 = cards_6;
        }
    }
}