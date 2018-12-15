using MVVM_Navigation.Services;
using MVVM_Navigation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Navigation
{
    class ViewModelLocator
    {
        private AppViewModel appViewModel;
        private FirstViewModel firstViewModel;
        private SecondViewModel secondViewModel;
        private ThirdViewModel thirdViewModel;

        private INavigationService navigationService;

        public ViewModelLocator()
        {
            navigationService = new NavigationService();
            appViewModel = new AppViewModel();
            firstViewModel = new FirstViewModel();
            secondViewModel = new SecondViewModel();
            thirdViewModel = new ThirdViewModel();
        }
    }
}
