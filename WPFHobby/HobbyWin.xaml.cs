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
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WPFHobby
{
    /// <summary>
    /// HobbyWin.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HobbyWin : Window
    {
        public HobbyWin()
        {
            InitializeComponent();
            Name2.Focus();
        }

        public string HBTitle
        {
            get { return Name2.Text; }
        }

        public string HBTerm
        {
            get { return Term.Text; }
        }

        public string HBSubject => Subject.Text;


        private void OnOK(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}