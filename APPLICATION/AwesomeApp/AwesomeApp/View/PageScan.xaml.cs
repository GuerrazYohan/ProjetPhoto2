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

        string value;


    public PageScan()
        {
            InitializeComponent();
            
            ButtonScanContinuously.Clicked += ButtonScanContinuously_Clicked;
           
            
        }


        //Permet de Scanner les QR code et les code barre en continue
        private async void ButtonScanContinuously_Clicked(object sender, EventArgs e)
        { 

                scanPage = new ZXingScannerPage(new ZXing.Mobile.MobileBarcodeScanningOptions { DelayBetweenContinuousScans = 3000 });
            scanPage.OnScanResult += (result) =>
                Device.BeginInvokeOnMainThread(() =>
             DisplayActionSheet("Résultat du scan", result.Text, "Cancel", null, "Partager","Télécharger"));
            
            await Navigation.PushModalAsync(scanPage);


        }
        public void VolunteerView()
        {
           
            backgroundImage.Source = new UriImageSource
            {
                Uri = new Uri(value),
                CachingEnabled = true,
                CacheValidity = new TimeSpan(5, 0, 0, 0)
            };
        }

        //Fonction pour partager 
        public async Task ShareText(string text)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = text,
                Title = "Share Text"
            });
        }

        public async Task ShareUri(string uri)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = uri,
                Title = "Share Web Link"
            });
        }

        public async Task ShareImg(string img)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = img,
                Title = "Share Web Link"
            });
        }





        //Naviguer jusqu'à la page home
        private void GoPageHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

    }
}