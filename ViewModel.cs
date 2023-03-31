using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    class CommonCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        Action<object> action;
        Func<object, bool> canExecute;
        public CommonCommand(Action<object> action, Func<object, bool> canExecute = null)
        {
            this.action = action;
            if (canExecute != null)
            {
                this.canExecute = canExecute;
            }
            else
            {
                this.canExecute = o => true;
            }
        }
        public bool CanExecute(object parameter)
        {
            return canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.action(parameter);
        }
    }
    internal class ViewModel : BaseViewModel
    {

        private string myProperty;
        public string MyProperty
        {
            get
            {
                return myProperty;
            }
            set
            {
                myProperty = value;
                RaisePropertyChanged(nameof(MyProperty));
            }
        }

        private BaseViewModel currentViewModel;

        public BaseViewModel CurrentViewModel
        {
            get { return currentViewModel; }
            set { currentViewModel = value; this.RaisePropertyChanged(nameof(CurrentViewModel)); }
        }

        public ICommand Home { get; set; }
        public ICommand About { get; set; }
        public ViewModel()
        {
            Home = new CommonCommand(HomeClick);
            About = new CommonCommand(AboutClick);

        }

        void HomeClick(object song)
        {
            this.CurrentViewModel = new HomeViewModel();
        }
        void AboutClick(object song)
        {
            this.CurrentViewModel = new AboutViewModel();
        }


    }
}
