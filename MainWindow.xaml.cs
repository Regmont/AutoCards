using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace AutoCards
{
    public partial class MainWindow : Window
    {
        public Deck deck;

        public MainWindow()
        {
            InitializeComponent();

            GameEffect effect = new GameEffect("Empty", false, 0);
            List<GameEffect> effects = new List<GameEffect>() { effect };
            Card card_1 = new Card("Basic card", 1, 1, 1, effects);
            List<Card> cards_lvl_1 = new List<Card>() { card_1, card_1, card_1 };
        }

        private void Grid_Initialized(object sender, System.EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(deck);
            mainMenu.Show();
            Close();
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
            {
                Close();
            }
        }
    }
}