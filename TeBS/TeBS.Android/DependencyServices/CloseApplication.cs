using System;
using TeBS.DependencyServices;
using TeBS.Droid.DependencyServices;
using Xamarin.Forms;

[assembly: Dependency(typeof(CloseApplication))]

namespace TeBS.Droid.DependencyServices
{
    public class CloseApplication : ICloseApplication
    {
        /// <summary>
        /// Closes the application.
        /// </summary>
        public void closeApplication()
        {

            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}
