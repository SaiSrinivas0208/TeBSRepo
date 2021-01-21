using System;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using TeBS.ViewModels;
using TeBS.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TeBS
{
    public partial class App : PrismApplication
    {
        #region Prism  

        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer) { }

        //public App()
        //{
        //    InitializeComponent();

        //    MainPage = new MainPage();
        //}

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<WelcomePage, WelcomePageViewModel>();


        }

        protected override void OnInitialized()
        {


            bool IsUserLoggedIn = false;
            if (Application.Current.Properties.ContainsKey("LoggedIn"))
            {
                var value = Application.Current.Properties["LoggedIn"].ToString();
                IsUserLoggedIn = bool.Parse(value);
            }

            if (IsUserLoggedIn)
            {

                NavigationService.NavigateAsync("/" + nameof(WelcomePage));
            }
            else
            {
                NavigationService.NavigateAsync("/" + nameof(LoginPage));
            }

            //NavigationService.NavigateAsync("/" + nameof(LoginPage));
        }
        #endregion
    }
}
