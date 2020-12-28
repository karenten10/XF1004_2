using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XF1004_2.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private readonly INavigationService navigationService;

        public string keyin { get; set; }

        public string display { get; set; }

        public DelegateCommand btnCommand { get; set; }

        public DelegateCommand nextCommand { get; set; }

        public MainPageViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            btnCommand = new DelegateCommand(ClickBtn);
            nextCommand = new DelegateCommand(ClickNext);
        }
        
        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        public void ClickBtn()
        {
            display = $"You are {keyin}.";
        }

        public void ClickNext()
        {
            // navigationService.NavigateAsync("NavigationPage/ShowPage"); // 這樣title會變成2行
            navigationService.NavigateAsync("ShowPage");
        }

    }
}
