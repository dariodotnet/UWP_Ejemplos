using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace AppMVVM.Base
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private Frame _appFrame;
        public Frame AppFrame => _appFrame;

        private Frame _splitViewFrame;
        public Frame SplitViewFrame => _splitViewFrame;

        public abstract Task OnNavigatedTo(NavigationEventArgs args);
        public abstract Task OnNavigatedFrom(NavigationEventArgs args);

        internal void SetAppFrame(Frame viewFrame)
        {
            _appFrame = viewFrame;
        }

        internal void SetSplitViewFrame(Frame viewFrame)
        {
            _splitViewFrame = viewFrame;
        }
    }
}
