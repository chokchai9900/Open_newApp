using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Open_newApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //Device.BeginInvokeOnMainThread(() =>
            //{
            //    input.Text = DeeplinkHandler.appstr;
            //});            
        }

        private async void OnClick_OpenKBank(object sender, EventArgs e)
        {

            var Appcall = ((Button)sender).BindingContext as string;
            //var result = await DependencyService.Get<IAppHandler>().LaunchApp(Appcall);
            await Launcher.OpenAsync(new Uri($"https://mlanding.azurewebsites.net?endpoint=https://s.manal.ink/auth/visit/{Appcall}?cid=client123"));
        }

        private async void nav_Webview(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new webview1());
        }
    }
}
