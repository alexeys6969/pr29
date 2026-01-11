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

namespace pcClubs.Pages.Clubs.Elements
{
    /// <summary>
    /// Логика взаимодействия для ClubItem.xaml
    /// </summary>
    public partial class ClubItem : UserControl
    {
        Main Main;
        Models.Clubs Club;
        public ClubItem(Models.Clubs club, Main main)
        {
            InitializeComponent();
            this.Name.Text = club.Name;
            this.Address.Text = club.Address;
            this.WorkTime.Text = club.WorkTime;
            Main = main;
            Club = club;
        }

        private void EditClub(object sender, RoutedEventArgs e)
        {
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this.Main, this.Club));
        }

        private void DeleteClub(object sender, RoutedEventArgs e)
        {
            Main.AllClub.Clubs.Remove(Club);
            Main.AllClub.SaveChanges();
            Main.parent.Children.Remove(this);
        }
    }
}
