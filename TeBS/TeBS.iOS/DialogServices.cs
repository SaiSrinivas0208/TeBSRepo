using System;
using Acr.UserDialogs;
using TeBS.DependencyServices;
using TeBS.iOS;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DialogServices))]

namespace TeBS.iOS
{
   
        public class DialogServices : IDialogService
        {
            UIActivityIndicatorView activityIndicatorView;

            /// <summary>
            /// Hides the loading.
            /// </summary>
            public void HideLoading()
            {
                UserDialogs.Instance.HideLoading();
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
                    title = "Error";// App.Translation.@default.errorTitle;
                if (string.IsNullOrEmpty(buttonText))
                    buttonText = "Ok";

                UserDialogs.Instance.Alert(message, title, buttonText);
            }

            /// <summary>
            /// Shows the loading.
            /// </summary>
            /// <param name="loadingText">Loading text.</param>
            public void ShowLoading(string loadingText = null)
            {
                UserDialogs.Instance.ShowLoading();
            }
        }
    
}
