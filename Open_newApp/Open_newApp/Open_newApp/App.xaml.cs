using System;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Open_newApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        protected override void OnAppLinkRequestReceived(Uri uri)
        {
            base.OnAppLinkRequestReceived(uri);
            DeeplinkHandler.Handle(uri.ToString());
        }
    }
}
