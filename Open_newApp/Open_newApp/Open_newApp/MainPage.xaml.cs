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
<<<<<<< HEAD
            //TODO : Create an button for call swap app bank
=======
            var appname = @"skype://com.scb.iphone";
            var result = await DependencyService.Get<IAppHandler>().LaunchApp(appname);
        }
>>>>>>> parent of 33fa29d (fix ios can't swap app)

            var Appcall = ((Button)sender).BindingContext as string;
            var result = await DependencyService.Get<IAppHandler>().LaunchApp(Appcall);
        }
    }
}
