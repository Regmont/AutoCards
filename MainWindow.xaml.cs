using System.Windows;

namespace AutoCards
{
    public partial class MainWindow : Window
    {
        Deck Deck;
        Tavern Tavern;
        Player Player;

        public MainWindow()
        {
            InitializeComponent();

            //Deck = new Deck(...);
            //Tavern = new Tavern(...);

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