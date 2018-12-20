using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Navigation.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Navigation.ViewModels
{
    class FirstViewModel : ViewModelBase
    {
        private string message;
        public string Message { get => message; set => Set(ref message, value); }

        public FirstViewModel()
        {
            Messenger.Default.Register<FirstMessage>(this,
            msg =>
            {
                Message = msg.Message;
            });
        }
    }
}
