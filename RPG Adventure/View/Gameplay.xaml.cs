using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Model;
using System.Windows.Input;
using System.Windows;
using System.Media;
using System.Windows.Threading;
using System.Windows.Media;

namespace RPG_Adventure
{
    /// <summary>
    /// Interaction logic for Gameplay.xaml
    /// </summary>
    public partial class Gameplay : UserControl, ISwitchable
    {
        private Player _player;
        private Monster _currentMonster;

        public static readonly List<Location> Locations = new List<Location>();
        public Gameplay()
        {
            InitializeComponent();

            using (SoundPlayer player = new SoundPlayer(@"..\..\Audio\theme.wav"))
            {
                player.Play();
            }

            List<InventoryItem> pInventory = new List<InventoryItem>();
            List<PlayerQuest> pQuest = new List<PlayerQuest>();

            pInventory.Add(new InventoryItem(new Longsword(1), 1));

            _player = new Player("Sorrow Woodentears");
            lblHitPoints.Content = _player.CurrentHitPoints.ToString();
            lblGold.Content = _player.Gold.ToString();
            lblExperience.Content = _player.ExperiencePoints.ToString();
            lblLevel.Content = _player.Level.ToString();
            lblName.Content = _player.Name;

            // Map Examples... we need to code this better. Inherit a baselocation, and have several .cs files with locations?
            // Also have random areas, where it takes X number of travels to get by.
            Location home = new Location(1, "Your house", "You really need to clean up the place.");
            Location townSquare = new Location(2, "Town square", "You see a fountain.");
            Location wilderness = new Location(3, "The Wilderness", "Nothing to be seen anywhere.");
            Location oldForest = new Location(4, "Old Forest", "This place is dark and creepy...");
            Location theTemple = new Location(5, "Dark Temple", "An eerie sound comes from the temple.");
            Location smallLake = new Location(6, "A Lake", "You feel like you are being watched.");

            // Link the locations together
            home.LocationToNorth = townSquare;
            townSquare.LocationToSouth = home;
            townSquare.LocationToNorth = wilderness;
            townSquare.LocationToWest = oldForest;
            wilderness.LocationToSouth = townSquare;
            oldForest.LocationToEast = townSquare;
            oldForest.LocationToNorth = theTemple;
            oldForest.LocationToWest = smallLake;
            theTemple.LocationToSouth = oldForest;
            smallLake.LocationToEast = oldForest;

            MoveTo(home);

            _player.CurrentLocation = home;
            _player.Inventory = pInventory;
        }

        #region ISwitchable Members
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void mainMenu_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new MainMenu());
        }
        #endregion

        private void repairButton_Click(object sender, RoutedEventArgs e)
        {
            if (testWindow.Visibility == Visibility.Hidden)
            {
                testWindow.Visibility = Visibility.Visible;
            }
            else
            {
                testWindow.Visibility = Visibility.Hidden;
            }
        }

        private void btnNorth_Click(object sender, RoutedEventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
        }

        private void btnWest_Click(object sender, RoutedEventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
        }

        private void btnEast_Click(object sender, RoutedEventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
        }

        private void btnSouth_Click(object sender, RoutedEventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
        }

        private void MoveTo(Location newLocation)
        {            
            _player.CurrentLocation = newLocation;

            // Show / Hide Movement buttons
            if (newLocation.LocationToNorth != null)
                btnNorth.Visibility = Visibility.Visible;
            else
                btnNorth.Visibility = Visibility.Hidden;
            if (newLocation.LocationToEast != null)
                btnEast.Visibility = Visibility.Visible;
            else
                btnEast.Visibility = Visibility.Hidden;
            if (newLocation.LocationToSouth != null)
                btnSouth.Visibility = Visibility.Visible;
            else
                btnSouth.Visibility = Visibility.Hidden;
            if (newLocation.LocationToWest != null)
                btnWest.Visibility = Visibility.Visible;
            else
                btnWest.Visibility = Visibility.Hidden;

            rtbLocation.Document.Blocks.Clear();
            rtbLocation.AppendText(newLocation.Name + "\r");

            rtbInformation.Document.Blocks.Clear();
            rtbInformation.AppendText(newLocation.Description);
        }
    }
}
