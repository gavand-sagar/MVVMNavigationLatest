using System.ComponentModel;

namespace WpfApp1
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        private string viewName;

        public string ViewName
        {
            get { return viewName; }
            set { viewName = value; RaisePropertyChanged(nameof(ViewName)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}