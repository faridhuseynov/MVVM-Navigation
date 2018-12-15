using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Navigation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM_Navigation.ViewModels
{
    class AppViewModel:ViewModelBase
    {
        private ViewModelBase currentPage;

        public ViewModelBase CurrentPage { get => currentPage; set => Set(ref currentPage, value); }

        private INavigationService navigationService = new NavigationService(); 

        public AppViewModel()
        {
            Messenger.Default.Register<ViewModelBase>(this, viewModel => CurrentPage = viewModel);
        }

        private RelayCommand<string> navigateCommand;

        public RelayCommand<string> NavigateCommand
        {
            get => navigateCommand ?? (navigateCommand = new RelayCommand<string>(
                param =>
                {

                }
                ));
        }

    }
}
