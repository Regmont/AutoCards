using System.Collections.Generic;

namespace AutoCards
{
    class Player
    {
        public int health { get; set; } = 30;
        public int money { get; set; } = 3;
        public List<Card> Cards { get; set; } = new List<Card>();
        public GameEffect PlayerAbility { get; set; }

        public Player(GameEffect playerAbility)
        {
            PlayerAbility = playerAbility;
        }
    }
}