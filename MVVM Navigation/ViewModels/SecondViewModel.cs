using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Navigation.ViewModels
{
    class SecondViewModel:ViewModelBase
    {
        private string text;
        public string Text
        {
            get => text;
            set => Set(ref text, value);
        }
    }
}
