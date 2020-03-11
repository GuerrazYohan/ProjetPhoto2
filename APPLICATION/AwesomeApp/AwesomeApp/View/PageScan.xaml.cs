using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeApp.View;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageScan : ContentPage
    {

        ZXingScannerPage scanPage;

       ZXingBarcodeImageView pageScanner;


    public PageScan()
        {
            InitializeComponent();
            
            ButtonScanContinuously.Clicked += ButtonScanContinuously_Clicked;
            
            
        }

        

     





        //Permet de Scanner les QR code et les code barre en continue
        private async void ButtonScanContinuously_Clicked(object sender, EventArgs e)
        { 

            //    scanPage = new ZXingScannerPage(new ZXing.Mobile.MobileBarcodeScanningOptions { DelayBetweenContinuousScans = 3000 });
            //scanPage.OnScanResult += (result) =>
            //    Device.BeginInvokeOnMainThread(() =>
            //       DisplayActionSheet("Scanned Barcode", result.Text, "Cancel", null, "Partager", "Télécharger"));

            //await Navigation.PushModalAsync(scanPage);



            scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                //Do something with result
                Device.BeginInvokeOnMainThread(async () => {
                    Navigation.PopModalAsync();


                   var Action = await DisplayActionSheet("Scanned Barcode", result.Text, "Cancel", null, "Partager", "Télécharger");

                    switch (Action)
                    {
                        case "Cancel":

                            // Do Something when 'Cancel' Button is pressed

                            break;

                        case "Partager":

                           await ShareUri(result.Text);

                            break;
                        case "Télécharger":

                            // Do Something when 'Button1' Button is pressed

                            break;

                    }


                });
            };

            await Navigation.PushModalAsync(scanPage);


        }

        public async Task ShareUri(string uri)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = uri,
                Title = "Share Web Link"
            });
        }














        private void GoPageHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

    }
}