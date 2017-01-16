using AppMVVM.ViewModels;
using Microsoft.Practices.Unity;

namespace AppMVVM.Base
{
    public class ViewModelLocator
    {
        private readonly IUnityContainer _container;

        public ViewModelLocator()
        {
            _container = new UnityContainer();

            _container.RegisterType<MainViewModel>();
        }

        public MainViewModel MainViewModel => _container.Resolve<MainViewModel>();
    }
}
