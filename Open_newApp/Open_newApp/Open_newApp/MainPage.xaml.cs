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

        private async void OnClick_OpenKBank(object sender, EventArgs e)
        {

            var Appcall = ((Button)sender).BindingContext as string;
            var result = await DependencyService.Get<IAppHandler>().LaunchApp(Appcall);
        }
    }
}
