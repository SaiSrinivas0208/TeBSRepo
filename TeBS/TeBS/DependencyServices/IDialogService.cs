using System;
using System.Threading.Tasks;

namespace TeBS.DependencyServices
{
    /// <summary>
    /// Helps to show/hide alert based on platform.
    /// </summary>
    ///


    public interface IDialogService
    {


        void ShowErrorAlert(string message, string title = "", string buttonText = "");

        void ShowLoading(string loadingText = null);

        void HideLoading();


    }
}
