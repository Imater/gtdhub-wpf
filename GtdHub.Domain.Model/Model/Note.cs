using System.ComponentModel;

namespace GtdHub.Domain.Model
{
    public class Note: BaseEntity, INotifyPropertyChanged 
    {
        string _title ;
        public string Title
        {
            get { return _title; }
            set
            {
                if (_title != value)
                {
                    _title = value;
                    RaisePropertyChanged("Title");
                }
            }
        }
        private void RaisePropertyChanged(string title)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(title));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
