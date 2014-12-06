using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;

namespace GtdHubApp.ViewModel
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        internal void RaisePropertyChanged(string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool? _closeWindowFlag;

        public bool? CloseWindowFlag
        {
            get { return _closeWindowFlag; }
            set { _closeWindowFlag = value; RaisePropertyChanged("CloseWindowFlag"); }
        }

        public virtual void CloseWindow(bool? result = true)
        {
            Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Background, new Action(() =>
            {
                CloseWindowFlag = CloseWindowFlag == null
                    ? true
                    : !CloseWindowFlag;
            }));
        }
    }
}
