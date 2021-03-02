using Foundation;
using Open_newApp.iOS;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(AppHandler))]
namespace Open_newApp.iOS
{
    public class AppHandler : IAppHandler
    {
        public Task<bool> LaunchApp(string packageName)
        {
            var deppLink = $"{packageName}://";
            var bankingList = new BankingList();
            var appData = bankingList.get().Find(it => it.Name == packageName);
            var location = RegionInfo.CurrentRegion.Name.ToLower();
            try
            {
                var canOpen = UIApplication.SharedApplication.CanOpenUrl(new NSUrl(deppLink));
                if (!canOpen) 
                {
                    string appURI = $"https://itunes.apple.com/th/app/{appData.Name}/id{appData.IdOnAppStore}";
                    UIApplication.SharedApplication.OpenUrl(new NSUrl(appURI));
                    return Task.FromResult(false);
                }
                return Task.FromResult(UIApplication.SharedApplication.OpenUrl(new NSUrl(deppLink)));
            }
            catch (Exception ex)
            {
                return Task.FromResult(false);
            }
        }
        public void OpenExternalApp(string packageName)
        {

            ////NSUrl request = new NSUrl("yourapp://");
            //var deppLink = $"{packageName}://";
            //var bankingList = new BankingList();
            //var appData = bankingList.get().Find(it => it.Name == packageName);
            //NSUrl appURL = new NSUrl("NowClinic://");
            //string appURI = $"https://itunes.apple.com/th/app/nowclinic/id{appData.IdOnAppStore}?mt=8";
            //try
            //{
            //    bool isOpened = UIApplication.SharedApplication.OpenUrl(appURL);

            //    if (isOpened == false)
            //        UIApplication.SharedApplication.OpenUrl(new NSUrl(appURI));
            //}
            //catch (Exception ex)
            //{
            //    var alertView = new UIAlertView("Error", ex.Message, null, "OK", null);
            //    alertView.Show();
            //}
            throw new NotImplementedException();
        }
    }
}