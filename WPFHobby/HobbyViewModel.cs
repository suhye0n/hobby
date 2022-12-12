using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using static WPFHobby.MainWindow;

namespace WPFHobby
{
    public class Hobby
    {
        // prop 탭 2번
        public string Title { get; set; }
        public string Term { get; set; }
        public string Subject { get; set; }

        public Hobby(string title, string term, string subject)
        {
            Title = title;
            Term = term;
            Subject = subject;
        }
    }
    class HobbyViewModel
    {
        ObservableCollection<Hobby> _list = new ObservableCollection<Hobby>();
        public ObservableCollection<Hobby> List
        {
            get { return _list; }
        }

        public HobbyViewModel()
        {

        }

        public void Add(Hobby hobby)
        {
            _list.Add(hobby);
        }
    }
}