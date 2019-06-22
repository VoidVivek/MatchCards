using MatchCards.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace MatchCards.Views
{
    /// <summary>
    /// Interaction logic for ActualMatchCardsPage.xaml
    /// </summary>
    public partial class ActualMatchCardsPage : UserControl, System.ComponentModel.INotifyPropertyChanged
    {
        public ActualMatchCardsPage()
        {
            InitializeComponent();
        }
        private int viewType;

        public event PropertyChangedEventHandler PropertyChanged;

        public int ViewType
        {
            get { return viewType; }
            set
            {
                viewType = value;
                OnPropertyChanged("ViewType");
               
            }
        }
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void listv_MouseEnter(object sender, MouseEventArgs e)
        {
            ViewType = 1;
        }

        private void listv_MouseLeave(object sender, MouseEventArgs e)
        {
            ViewType = 2;
        }

    }
}
