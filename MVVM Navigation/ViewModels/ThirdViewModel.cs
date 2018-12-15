using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Navigation.ViewModels
{
    class ThirdViewModel:ViewModelBase
    {
        private string message;
        public string Message
        {
            get => message;
            set => Set(ref message, value);
        }
        public ThirdViewModel()
        {
            Messenger.Default.Register<string>(this, msg => Message = msg);
        }
    }
}
