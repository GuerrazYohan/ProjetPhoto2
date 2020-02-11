using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageScan : ContentPage
    {

        ZXingScannerPage scanPage;
        public PageScan()
        {
            InitializeComponent();
            ButtonScanDefault.Clicked += ButtonScanDefault_Clicked;
            ButtonScanCustom.Clicked += ButtonScanCustom_Clicked;
            ButtonScanContinuously.Clicked += ButtonScanContinuously_Clicked;
            ButtonScanCustomPage.Clicked += ButtonScanCustomPage_Clicked;
        }


        //Permet de Scanner les QR code et les afficher dans une autre page
        private async void ButtonScanCustomPage_Clicked(object sender, EventArgs e)
        {
            var customScanPage = new PageScan2();
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                //Do something with result
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopModalAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            await Navigation.PushModalAsync(scanPage);
        }





        //Permet de Scanner les QR code et les code barre en continue
        private async void ButtonScanContinuously_Clicked(object sender, EventArgs e)
        {
            scanPage = new ZXingScannerPage(new ZXing.Mobile.MobileBarcodeScanningOptions { DelayBetweenContinuousScans = 3000 });
            scanPage.OnScanResult += (result) =>
                Device.BeginInvokeOnMainThread(() =>
                   DisplayAlert("Scanned Barcode", result.Text, "OK"));

            await Navigation.PushModalAsync(scanPage);
        }


        //Permet de Scanner les QR code et les code barre avec flache
        private async void ButtonScanCustom_Clicked(object sender, EventArgs e)
        {
            // Create our custom overlay
            var customOverlay = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var torch = new Button
            {
                Text = "Toggle Torch"
            };
            torch.Clicked += delegate {
                scanPage.ToggleTorch();
            };
            customOverlay.Children.Add(torch);

            scanPage = new ZXingScannerPage(new ZXing.Mobile.MobileBarcodeScanningOptions { AutoRotate = true }, customOverlay: customOverlay);
            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopModalAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
            await Navigation.PushModalAsync(scanPage);
        }




        //Permet de Scanner les QR code et les code barre
        private async void ButtonScanDefault_Clicked(object sender, EventArgs e)
        {
            scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                //Do something with result
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopModalAsync();
                    DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };

            await Navigation.PushModalAsync(scanPage);
        }




        private void GoPageHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

    }
}