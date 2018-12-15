﻿using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Navigation.Services
{
    interface INavigationService
    {
        void Navigate(string viewName);

        void Register(string viewName, ViewModelBase viewModel);
    }
}