﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace MVVM_Navigation.Services
{
    class NavigationService : INavigationService
    {
        private Dictionary<Type, ViewModelBase> viewModels = new Dictionary<Type, ViewModelBase>();

        public void Register<T>(ViewModelBase viewModel)
        {
            viewModels.Add(typeof(T), viewModel);
        }

        public void Navigate<T>()
        {
            Messenger.Default.Send(viewModels[typeof(T)]);
        }

        public void Navigate(Type type)
        {
            Messenger.Default.Send(viewModels[type]);
        }


        //private Dictionary<string, ViewModelBase> viewModels = new Dictionary<string, ViewModelBase>();

        //public void Navigate(string viewName)
        //{
        //    Messenger.Default.Send(viewModels[viewName]);
        //}

        //public void Register(string viewName, ViewModelBase viewModel)
        //{
        //    viewModels.Add(viewName, viewModel);
        //}
    }
}
