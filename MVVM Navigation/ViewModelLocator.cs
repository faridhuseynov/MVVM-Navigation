using GalaSoft.MvvmLight;
using MVVM_Navigation.Services;
using MVVM_Navigation.ViewModels;
using System;
using System.Windows;

namespace MVVM_Navigation
{
    class ViewModelLocator
    {
        private AppViewModel appViewModel;
        private FirstViewModel firstViewModel;
        private SecondViewModel secondViewModel;
        private ThirdViewModel thirdViewModel;

        private INavigationService navigationService;

        public static IContainer Container;

        public ViewModelLocator()
        {
            try
            {
                var config = new ConfigurationBuilder();
                config.AddJsonFile("autofac.json");
                var module = new ConfigurationModule(config.Build());
                var builder = new ContainerBuilder();
                builder.RegisterModule(module);
                Container = builder.Build();

                //var builder = new ContainerBuilder();
                //builder.RegisterType<AppViewModel>();
                //builder.RegisterType<FirstViewModel>();
                //builder.RegisterType<SecondViewModel>();
                //builder.RegisterType<ThirdViewModel>();
                //builder.RegisterType<MessageService>().As<IMessageService>();
                ////builder.RegisterInstance<NavigationService>(new NavigationService()).As<INavigationService>();
                //builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();
                //Container = builder.Build();

                navigationService = Container.Resolve<INavigationService>();
                appViewModel = Container.Resolve<AppViewModel>();
                firstViewModel = Container.Resolve<FirstViewModel>();
                secondViewModel = Container.Resolve<SecondViewModel>();
                thirdViewModel = Container.Resolve<ThirdViewModel>();

                navigationService.Register<FirstViewModel>(firstViewModel);
                navigationService.Register<SecondViewModel>(secondViewModel);
                navigationService.Register<ThirdViewModel>(thirdViewModel);

                navigationService.Navigate<FirstViewModel>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public ViewModelBase GetAppViewModel()
        {
            return appViewModel;
        }
    }
}
