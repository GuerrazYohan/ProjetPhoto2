using System;
using ZXing.Net.Mobile;
using ZXing.Net.Mobile.Forms;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.DownloadManager;
using Plugin.DownloadManager.Abstractions;
using System.IO;
using System.Linq;

namespace AwesomeApp.Droid
{
    [Activity(Label = "PhotoBooth", Icon = "@mipmap/logo", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            ZXing.Net.Mobile.Forms.Android.Platform.Init();

            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            Window.SetStatusBarColor(Android.Graphics.Color.Argb(255, 0, 0, 0));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            global::ZXing.Net.Mobile.Android.PermissionsHandler.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }


        public void Downloaded()
        {
            CrossDownloadManager.Current.PathNameForDownloadedFile = new System.Func<IDownloadFile, string>(file =>
            {
                string fileName = Android.Net.Uri.Parse(file.Url).Path.Split('/').Last();
                return Path.Combine(ApplicationContext.GetExternalFilesDir(Android.OS.Environment.DirectoryDownloads).AbsolutePath, fileName);
            });
        }


    }
}