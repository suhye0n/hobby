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

namespace WPFHobby
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        HobbyViewModel HobbyList = new HobbyViewModel();

        public MainWindow()
        {
            InitializeComponent();

            Grid.ItemsSource = HobbyList.List;

            HobbyList.Add(new Hobby("볼링", "주 1회", "운동"));
            HobbyList.Add(new Hobby("피아노", "주 3회", "음악"));
        }

        private void OnAdd(object sender, RoutedEventArgs e)
        {
            HobbyWin g = new HobbyWin();
            if (g.ShowDialog() != true)
                return;

            HobbyList.Add(new Hobby(g.HBTitle, g.HBTerm, g.HBSubject));
        }

        private void OnChanged(object sender, SelectionChangedEventArgs e)
        {
            Hobby g = (Hobby)Grid.SelectedItem;

            BitmapImage b = new BitmapImage(new Uri($"images/{g.Title}.png",
                UriKind.RelativeOrAbsolute));
            Image.Source = b;
        }
    }
}