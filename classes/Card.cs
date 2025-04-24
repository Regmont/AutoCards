using System.Collections.Generic;

namespace AutoCards
{
    public class Card
    {
        public string name { get; }
        public int rang { get; }
        public int health { get; set; }
        public int damage { get; set; }
        public bool golden { get; set; } = false;
        public List<GameEffect> Effects { get; set; }

        public Card(string name, int rang, int health, int damage, List<GameEffect> effects)
        {
            this.name = name;
            this.rang = rang;
            this.health = health;
            this.damage = damage;
            Effects = effects;
        }
    }
}