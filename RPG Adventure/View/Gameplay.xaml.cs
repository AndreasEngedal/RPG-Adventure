using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Model;

namespace RPG_Adventure
{
    /// <summary>
    /// Interaction logic for Gameplay.xaml
    /// </summary>
    public partial class Gameplay : UserControl, ISwitchable
    {        
        private Player player;

        public Gameplay()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house.");
            //player = new Player(15, 15, 20, 0, 1, "Malte Balslev");
            player = new Player("Sorrow Woodentears");
            lblHitPoints.Content = player.CurrentHitPoints.ToString();
            lblGold.Content = player.Gold.ToString();
            lblExperience.Content = player.ExperiencePoints.ToString();
            lblLevel.Content = player.Level.ToString();
            lblName.Content = player.Name;
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
        #endregion
    }
}
