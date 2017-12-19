using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

using Xamarin.Forms;

namespace tabbedpage
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new tabbedpage.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("android=b48fe815-387b-4aa0-86c0-3532ebd75853;",
                typeof(Analytics),
                typeof(Crashes));
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
