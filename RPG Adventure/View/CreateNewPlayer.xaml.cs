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
        DataController controller;

        public CreateNewPlayer(DataController controller)
        {
            InitializeComponent();
            this.controller = controller;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
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
    }
}
