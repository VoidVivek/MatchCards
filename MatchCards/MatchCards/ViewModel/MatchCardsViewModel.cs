using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MatchCards.Annotations;

namespace MatchCards.ViewModel
{
    public class MatchCardsViewModel : INotifyPropertyChanged
    {
        private bool _isActualPage = false;
        private bool _isPlayVisible;
        public bool IsActualPage
        {
            get
            {
                return _isActualPage;
            }
            set
            {
                _isActualPage = value;
                OnPropertyChanged();
            }
        }

        public bool IsPlayVisible
        {
            get
            {
                return _isPlayVisible;
            }
            set
            {
                _isPlayVisible = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public MatchCardsViewModel()
        {

        }
    }
}
