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
        public class Hobby
        {
            public string Title { get; set; }
            public string Cate { get; set; }
            public string Desc { get; set; }

            public Hobby(string title, string cate, string desc)
            {
                Title = title;
                Cate = cate;
                Desc = desc;
            }
        }

        protected List<Hobby> HobbyList = new List<Hobby>();

        public MainWindow()
        {
            InitializeComponent();
            Grid.ItemsSource = HobbyList;
        }
    }
}
