using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Model;
using System.Windows.Input;
using System.Windows;

namespace RPG_Adventure
{
    /// <summary>
    /// Interaction logic for CreateNewPlayer.xaml
    /// </summary>
    public partial class CreateNewPlayer : UserControl, ISwitchable
    {
        PlayerController controller;

        public CreateNewPlayer(PlayerController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (txtBoxNewPlayer.Text == string.Empty)
                MessageBox.Show("Please write a name.");
            if (txtBoxNewPlayer.Text.Length > 15)
                MessageBox.Show("Name can't be longer than 15 characters.");
            bool alreadyTaken = false;
            foreach (Player player in controller.players)
            {
                if (player.Name == txtBoxNewPlayer.Text)
                    alreadyTaken = true;
            }
            if (alreadyTaken == false)
            {
                controller.CreateNewPlayer(txtBoxNewPlayer.Text);
                MessageBox.Show("Player created!");
                Switcher.Switch(new Gameplay());
            }
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
        #endregion

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
    }
}
