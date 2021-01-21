using System;
using Acr.UserDialogs;
using Android.App;
using TeBS.DependencyServices;
using TeBS.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(DialogServices))]

namespace TeBS.Droid.DependencyServices
{
    public class DialogServices : IDialogService
    {
        protected Android.App.ProgressDialog progressDialog;


        /// <summary>
        /// Hides the loading.
        /// </summary>
        public void HideLoading()
        {
            UserDialogs.Instance.HideLoading();
        }

    
    
        /// <summary>
        /// Shows the loading.
        /// </summary>
        /// <param name="loadingText">Loading text.</param>
        public void ShowLoading(string loadingText = null)
        {
            UserDialogs.Instance.ShowLoading();

        }


        /// <summary>
        /// Shows the error alert.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="title">Title.</param>
        /// <param name="buttonText">Button text.</param>
        public void ShowErrorAlert(string message, string title = "", string buttonText = "")
        {
            if (string.IsNullOrEmpty(title))
                title = "Error";
            if (string.IsNullOrEmpty(buttonText))
                buttonText = "Ok";

            UserDialogs.Instance.Alert(message, title, buttonText);
        }
    }
}
