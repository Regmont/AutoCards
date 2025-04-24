using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace AutoCards
{
    public partial class MainMenu : Window
    {
        Deck Deck;
        Tavern Tavern;
        Player Player;

        public MainMenu(Deck deck)
        {
            InitializeComponent();

            Deck = deck;

            List<Card> cards = new List<Card>();
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                int value = random.Next(0, deck.Cards_1.Count);
                Card card = deck.Cards_1.ElementAt(value);
                cards.Add(card);
                deck.Cards_1.Remove(card);
            }

            Tavern = new Tavern(cards);

            GameEffect gameEffect = new GameEffect("Test", false, 0);
            Player = new Player(gameEffect);

            labelTavernLevel.Content = "1";
            labelTavernUp.Content = "5";
            labelReroll.Content = "1";

            labelHP.Content = Player.health;
            labelMoney.Content = Player.money;
            labelPlayerAbility.Content = Player.PlayerAbility.name;
            labelTurn.Content = "1";
            labelTimer.Content = "40";
        }
    }
}
