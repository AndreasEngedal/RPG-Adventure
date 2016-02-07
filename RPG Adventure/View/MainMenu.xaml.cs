using System;
using System.Windows;
using System.Windows.Controls;
using Model;

namespace RPG_Adventure
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl, ISwitchable
    {
        DataController controller;
        public MainMenu()
        {
            InitializeComponent();
            controller = new DataController();
        }

        private void newPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Gameplay());
        }

        private void loadPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            //Switcher.Switch(new LoadGame());
        }

        private void exitGameButton_Click(object sender,RoutedEventArgs e)
        {
            //Switcher.Switch(new ShowCreditsAndExit());
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
