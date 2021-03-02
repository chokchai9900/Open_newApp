using Android.App;  
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Open_newApp.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(OpenAppAndroid))]
namespace Open_newApp.Droid
{
    public class OpenAppAndroid : IAppHandler
    {
        public Task<bool> LaunchApp(string appname)
        {
            bool result = false;

            var bankingList = new BankingList();
            var appData = bankingList.get().Find(it => it.Name == appname);

            PackageManager pm = Android.App.Application.Context.PackageManager;

            Intent intent = pm.GetLaunchIntentForPackage(appData.BundleId);

            try
            {
                if (IsAppInstalled(appData.BundleId))
                {
                    if (intent != null)
                    {
                        intent.SetFlags(ActivityFlags.NewTask);
                        Android.App.Application.Context.StartActivity(intent);
                    }
                }
                else  
                {
                    intent = new Intent(Intent.ActionView);
                    intent.AddFlags(ActivityFlags.NewTask);
                    intent.SetData(Android.Net.Uri.Parse($"market://details?id={appData.BundleId}"));
                    Android.App.Application.Context.StartActivity(intent);
                }
            }
            catch (ActivityNotFoundException)
            {
                result = false;
            }

            return Task.FromResult(result);
        }

        private bool IsAppInstalled(string packageName)
        {
            PackageManager pm = Android.App.Application.Context.PackageManager;
            bool installed = false;
            try
            {
                pm.GetPackageInfo(packageName, PackageInfoFlags.Activities);
                installed = true;
            }
            catch (PackageManager.NameNotFoundException e)
            {
                installed = false;
            }

            return installed;
        }

        public void OpenExternalApp(string packageName)
        {
            Intent intent = Android.App.Application.Context.PackageManager.GetLaunchIntentForPackage(packageName);
            if (intent != null)
            {
                intent.AddFlags(ActivityFlags.NewTask);
                Forms.Context.StartActivity(intent);
            }
            else
            {
                intent = new Intent(Intent.ActionView);
                intent.AddFlags(ActivityFlags.NewTask);
                intent.SetData(Android.Net.Uri.Parse($"market://details?id={packageName}"));
                Forms.Context.StartActivity(intent);
            }
        }
    }
}