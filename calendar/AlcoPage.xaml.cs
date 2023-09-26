using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

namespace calendar
{
    /// <summary>
    /// Логика взаимодействия для AlcoPage.xaml
    /// </summary>
    public partial class AlcoPage : Page
    {
        public AlcoPage()
        {
            InitializeComponent();

            Alco beer = new Alco();
            beer.ImageAlco.Source = new BitmapImage(new Uri("/image/beer.png", UriKind.Relative));
            beer.NameAlco.Text = "Пиво";
            Alco wine = new Alco();
            wine.ImageAlco.Source = new BitmapImage(new Uri("/image/wine.png", UriKind.Relative));
            wine.NameAlco.Text = "Вино";
            Alco cocktail = new Alco();
            cocktail.ImageAlco.Source = new BitmapImage(new Uri("/image/cocktail.png", UriKind.Relative));
            cocktail.NameAlco.Text = "Коктейль";
            Alco whiskey = new Alco();
            whiskey.ImageAlco.Source = new BitmapImage(new Uri("/image/whickey.png", UriKind.Relative));
            whiskey.NameAlco.Text = "Виски";

            List<Alco> alcos = new List<Alco>() { beer, wine, cocktail, whiskey };
            AlcoList.ItemsSource = alcos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new CalendarPage();
        }
    }
}
