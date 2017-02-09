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
            _container.RegisterType<SecondViewModel>();
            _container.RegisterType<OtherViewModel>();
        }

        public MainViewModel MainViewModel => _container.Resolve<MainViewModel>();
        public SecondViewModel SecondViewModel => _container.Resolve<SecondViewModel>();
        public OtherViewModel OtherViewModel => _container.Resolve<OtherViewModel>();
    }
}
