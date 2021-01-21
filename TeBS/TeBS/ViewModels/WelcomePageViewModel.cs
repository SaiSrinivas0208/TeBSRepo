using System;
using Prism.Navigation;

namespace TeBS.ViewModels
{
    public class WelcomePageViewModel:BaseViewModel,INavigatedAware
    {

        public WelcomePageViewModel(INavigationService navigationService):base(navigationService)
        {
        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
