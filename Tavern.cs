using System.Collections.Generic;

namespace AutoCards
{
    class Tavern
    {
        public int level { get; set; } = 1;
        public int upgradeCost { get; set; } = 5;
        public List<Card> Cards { get; set; }

        public Tavern(List<Card> cards)
        {
            Cards = cards;
        }
    }
}