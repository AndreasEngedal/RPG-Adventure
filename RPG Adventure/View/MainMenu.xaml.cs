using System;
using System.Windows;
using System.Windows.Controls;
using Model;
using System.Windows.Input;

namespace RPG_Adventure
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : UserControl, ISwitchable
    {
        PlayerController controller;
        public MainMenu()
        {
            InitializeComponent();
            controller = new PlayerController();
        }

        private void newPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CreateNewPlayer(controller));
        }

        private void loadPlayerButton_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new Gameplay());
        }

        private void exitGameButton_Click(object sender,RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
