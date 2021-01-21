using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Navigation;
using TeBS.DependencyServices;
using TeBS.Utility;
using TeBS.Views;
using Xamarin.Forms;

namespace TeBS.ViewModels
{
    public class LoginPageViewModel:BaseViewModel,INavigationAware
    {

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {

        }
        private string _error;
        public string Error
        {
            get { return _error; }
            set
            {
                _error = value;
                if (!string.IsNullOrEmpty(_error))
                {
                    IsErrorVisible = true;
                }
                RaisePropertyChanged("Error");
            }
        }

        private bool _isSubmitEnable = true;
        public bool IsSubmitEnable
        {
            get { return _isSubmitEnable; }
            set
            {
                _isSubmitEnable = value;
                RaisePropertyChanged("IsSubmitEnable");
            }
        }

        private bool _isErrorVisible;
        public bool IsErrorVisible
        {
            get { return _isErrorVisible; }
            set
            {
                _isErrorVisible = value;
                if (!_isErrorVisible)
                {
                    Error = string.Empty;
                }
                RaisePropertyChanged("IsErrorVisible");
            }
        }
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                if (UserName == null || _password == null || _password?.Length == 0 || UserName?.Length == 0)
                    IsSubmitEnable = false;
                else
                    IsSubmitEnable = true;

                if (_password.Length > 0)
                {
                    IsErrorVisible = false;
                }
                RaisePropertyChanged("Password");
            }
        }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                if (_userName == null || Password == null || _userName?.Length == 0 || Password?.Length == 0)
                    IsSubmitEnable = false;
                else
                    IsSubmitEnable = true;

                if (_userName.Length > 0)
                {
                    IsErrorVisible = false;
                }
                RaisePropertyChanged("UserName");
            }
        }
        public ICommand LoginCommand
        {
            get
            {
                return new Command(HandleLoginCommand, LoginCommandcanExecute);
            }
        }

        private async void HandleLoginCommand(object obj)
        {
            CanExecuteCommands = false;
            await LoginAction();
            CanExecuteCommands = true;
        }

        private bool LoginCommandcanExecute(object arg)
        {
            return CanExecuteCommands;
        }
        private async Task LoginAction()
        {
            if (IsSubmitEnable)
            {
                DependencyService.Get<IDialogService>().ShowLoading();

                if (UserName.ToLower() == ICConstants.Admin && Password.ToLower() == ICConstants.Password)
                {
                    Application.Current.Properties["LoggedIn"] = "true";
                    await navigationService.NavigateAsync(PageConstants.WelcomePage);
                    DependencyService.Get<IDialogService>().HideLoading();

                }
                else
                {
                    DependencyService.Get<IDialogService>().HideLoading();
                    DependencyService.Get<IDialogService>().ShowErrorAlert(ICConstants.IncorrectDetails, ICConstants.Warning, ICConstants.Ok);

                }
            }
            else
            {
                DependencyService.Get<IDialogService>().ShowErrorAlert(ICConstants.NotEnteredDetails, ICConstants.Warning, ICConstants.Ok);

            }


        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }
    }
}
