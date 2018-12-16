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
    class SecondViewModel:ViewModelBase
    {
        private string text;
        public string Text
        {
            get => text;
            set => Set(ref text, value);
        }

        private readonly INavigationService navigation;
        public SecondViewModel(INavigationService navigation)
        {
            this.navigation = navigation;
        }
        private RelayCommand<string> sendCommand;

        public RelayCommand<string> SendCommand
        {
            get => sendCommand ?? (sendCommand = new RelayCommand<string>(

                param =>
                {
                    if (param == "First")
                    {
                        Messenger.Default.Send(new FirstMessage { Message = Text });
                        navigation.Navigate("First");
                    }
                    else if (param == "Third")
                    {
                        Messenger.Default.Send(new ThirdMessage { Message = Text });
                        navigation.Navigate("Third");
                    }
                    Text = "";
                }
                ));
        }

    }
}
