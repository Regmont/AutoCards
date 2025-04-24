using System.Windows;

namespace AutoCards
{
    class GameEffect
    {
        public string name { get; }
        public bool active { get; }
        public int effectIndex { get; }

        public GameEffect(string name, bool active, int effectIndex)
        {
            this.name = name;
            this.active = active;
            this.effectIndex = effectIndex;
        }

        public void Activate()
        {
            switch(effectIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    MessageBox.Show(
                        "Impossible effect!", "Error!",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
        }
    }
}