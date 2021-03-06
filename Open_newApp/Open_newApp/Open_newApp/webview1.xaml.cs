using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Open_newApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class webview1 : ContentPage
    {
        public webview1()
        {
            InitializeComponent();
            weburi.Source = "https://auidp.azurewebsites.net/Account/Login";
        }
    }
}