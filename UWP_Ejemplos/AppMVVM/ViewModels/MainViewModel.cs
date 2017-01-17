using AppMVVM.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace AppMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _holaMundo;
        public string HolaMundo
        {
            get { return _holaMundo; }
            set
            {
                _holaMundo = value;
                RaisePropertyChanged();
            }
        }

        private SolidColorBrush _appBackground;
        public SolidColorBrush AppBackground
        {
            get { return _appBackground; }
            set
            {
                _appBackground = value;
                RaisePropertyChanged();
            }
        }

        private ICommand changeColorCommand;
        public ICommand ChangeColorCommand
        {
            get { return changeColorCommand = changeColorCommand ?? new DelegateCommand(ChangeColorExecute); }
        }

        private void ChangeColorExecute()
        {
            AppBackground = new SolidColorBrush(Colors.Pink);
        }

        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            HolaMundo = "Hola mundo desde el ViewModel!!!";
            AppBackground = new SolidColorBrush(Colors.Azure);
            return null;
        }

        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }
    }
}