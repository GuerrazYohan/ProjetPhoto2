using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageScan : ContentPage
    {
        public Action<object> OnScanResult { get; private set; }
        public bool IsScanning { get; private set; }

        public PageScan()
        {
            InitializeComponent();
        }




        private void OpenScanner(object sender, EventArgs e)
        {
            Scanner();
        }

        public async void Scanner()
        {

            var ScannerPage = new PageScan();

            ScannerPage.OnScanResult += (result) => {
                // Parar de escanear
                ScannerPage.IsScanning = false;

                // Alert com o código escaneado
                Device.BeginInvokeOnMainThread(() => {
                    Navigation.PopAsync();
                    DisplayAlert("Código escaneado", result , "OK");
                });
            };


            await Navigation.PushAsync(ScannerPage);

        }

        private void DisplayAlert(string v1, object text, string v2)
        {
            throw new NotImplementedException();
        }

        private void GoPageHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

    }
}