using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPG_Adventure
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataController controller;
        public MainWindow()
        {
            InitializeComponent();
            controller = new DataController();
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == String.Empty)
                MessageBox.Show("Please write a name!");
            else
            {
                int counter = 0;
                foreach (Hero hero in controller.heroes)
                {
                    if (hero.Name == textBox.Text)
                    {
                        MessageBox.Show("A Hero with this name already exists!");
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    controller.CreateHero(textBox.Text);
                    MessageBox.Show("Hero created!");
                    textBox.Text = String.Empty;
                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int deletedHeroId = controller.DeleteHero(textBox.Text);
            if (deletedHeroId != -1)
            {
                controller.heroes.Remove(controller.heroes[deletedHeroId]);
                MessageBox.Show("Hero deleted!");
                textBox.Text = String.Empty;
                counter++;
            }
        }
        private int counter = 0;
        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            if (controller.heroes.Count == 0)
                MessageBox.Show("Empty list!");
            else
            {
                counter = 0;
                textBox.Text = controller.heroes[counter].Name;
 
            }
        }
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (controller.heroes.Count == 0)
                MessageBox.Show("Empty list!");
            else
            {
                if (counter == controller.heroes.Count - 1)
                    counter = 0;
                else
                    counter++;
                textBox.Text = controller.heroes[counter].Name;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (controller.heroes.Count == 0)
                MessageBox.Show("Empty list!");
            else
            {
                if (counter == 0)
                    counter = controller.heroes.Count - 1;
                else
                    counter--;
                textBox.Text = controller.heroes[counter].Name;
            }
        }
    }
}
