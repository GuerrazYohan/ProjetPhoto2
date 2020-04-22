using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using AwesomeApp.View;
using Plugin.DownloadManager;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZXing.Net.Mobile.Forms;
using AwesomeApp.Model;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageScan : ContentPage
    {
     
        
        ZXingScannerPage scanPage;

       ZXingBarcodeImageView pageScanner;

        public string result { get; set; }
       
  
        public PageScan()
        {
            InitializeComponent();

            

            ButtonScanContinuously.Clicked += ButtonScanContinuously_Clicked;
            
            
        }









        //Permet de Scanner les QR code et les code barre en continue
        //    scanPage = new ZXingScannerPage(new ZXing.Mobile.MobileBarcodeScanningOptions { DelayBetweenContinuousScans = 3000 });
        //scanPage.OnScanResult += (result) =>
        //    Device.BeginInvokeOnMainThread(() =>
        //       DisplayActionSheet("Scanned Barcode", result.Text, "Cancel", null, "Partager", "Télécharger"));

        //await Navigation.PushModalAsync(scanPage);
        private async void ButtonScanContinuously_Clicked(object sender, EventArgs e)
        { 

            scanPage = new ZXingScannerPage();

            scanPage.OnScanResult += (result) => {
                scanPage.IsScanning = false;

                //Do something with result
                Device.BeginInvokeOnMainThread(async () => {
                    await Navigation.PopModalAsync();


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

                             DownloadFile(result.Text);

                            break;

                    }


                });
            };

            await Navigation.PushModalAsync(scanPage);

        }

       

        //Fonction pour partager un fichier
        public async Task ShareUri(string uri)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = uri,
                Title = "Share Web Link"
            });
        }


        //Fonction pour télécharger un fichier

        public void DownloadFile(string address)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(address);

            Console.WriteLine(reply);
        }

        private void GoPageHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

    }



    



}