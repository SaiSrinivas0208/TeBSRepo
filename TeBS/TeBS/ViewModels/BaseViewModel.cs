using System;
using Prism.Mvvm;
using Prism.Navigation;

namespace TeBS.ViewModels
{
    public class BaseViewModel: BindableBase
    {
        public INavigationService navigationService;
        protected bool CanExecuteCommands { get; set; } = true;

        public BaseViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        public BaseViewModel()
        {

        }

    }
}
