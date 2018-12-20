using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using MVVM_Navigation.Messages;
using MVVM_Navigation.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Navigation.ViewModels
{
    class ThirdViewModel : ViewModelBase
    {
        private string message;
        public string Message { get => message; set => Set(ref message, value); }

        private readonly IMessageService messageService;

        public ThirdViewModel(IMessageService messageService)
        {
            Messenger.Default.Register<ThirdMessage>(this,
            msg =>
            {
                Message = msg.Message;
            });
            this.messageService = messageService;
        }

        private RelayCommand alertCommand;
        public RelayCommand AlertCommand
        {
            get => alertCommand ?? (alertCommand = new RelayCommand(
                () =>
                {
                    //var mService = ViewModelLocator.Container.Resolve<IMessageService>();
                    //mService.ShowInfo("Test");

                    messageService.ShowInfo(Message);
                }
            ));
        }
    }
}
