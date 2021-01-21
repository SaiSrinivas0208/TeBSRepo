using TeBS.DependencyServices;
using Xamarin.Forms;

namespace TeBS.Views
{
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {

            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            DependencyService.Get<ICloseApplication>().closeApplication();
            return base.OnBackButtonPressed();
            
        }
    }
}
