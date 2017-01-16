using AppMVVM.Base;
using System.Threading.Tasks;
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
        public override Task OnNavigatedTo(NavigationEventArgs args)
        {
            HolaMundo = "Hola mundo desde el ViewModel!!!";
            return null;
        }

        public override Task OnNavigatedFrom(NavigationEventArgs args)
        {
            return null;
        }
    }
}
