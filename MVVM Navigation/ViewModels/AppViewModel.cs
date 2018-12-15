using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
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

        private Dictionary<string, ViewModelBase> viewModels = new Dictionary<string, ViewModelBase>();

        public AppViewModel()
        {
            viewModels.Add("First", new FirstViewModel());
            viewModels.Add("Second", new SecondViewModel());
        }

        private RelayCommand<string> navigateCommand;

        public RelayCommand<string> NavigateCommand
        {
            get => navigateCommand ?? (navigateCommand = new RelayCommand<string>(
                param =>
                {
                        CurrentPage =viewModels[param];
                }
                ));
        }

    }
}
