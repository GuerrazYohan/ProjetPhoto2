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
using System.ComponentModel;
using AwesomeApp.Model;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageScan : ContentPage
    {
        readonly PageScanViewModel modelScan;
        
        ZXingScannerPage scanPage;

       ZXingBarcodeImageView pageScanner;

        public string result { get; set; }
       
  
        public PageScan()
        {
            InitializeComponent();
            modelScan = new PageScanViewModel();
            this.BindingContext = modelScan;


            ButtonScanContinuously.Clicked += ButtonScanContinuously_Clicked;
            
            
        }



        //Permet de scanner le QR code 
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


                            await ReachPhoto(result.Text);
                            //await ShareUri(result.Text);

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

        //retour à la page menu
        private void GoPageHome_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

        //Une fois le scan effectuer la fonction vas récupérer le chemin d'acces de la photo
        public async Task ReachPhoto(string NPhoto)
        {
            List<Photo> unLog = new List<Photo>();
            NPhoto = NPhoto.Substring(7);
            try
            {
                HttpClient client = new HttpClient();
                var uri = new Uri("http://109.16.248.248/WebServiceSlim/Get/RoutePictureWithRoute");

                
                
                JObject oJsonObject = new JObject
                {
                   {"Route", NPhoto},
                        
                };


                var reponse = await client.PostAsync(uri, new StringContent(oJsonObject.ToString(), Encoding.UTF8, "application/json"));

                if (reponse.IsSuccessStatusCode)
                {
                    string content = await reponse.Content.ReadAsStringAsync();
                    if (!content.Equals("[]"))
                    {
                        unLog = JsonConvert.DeserializeObject<List<Photo>>(content);
                        MessageError.Text = null;
                        Xamarin.Forms.Application.Current.Properties["resultatscanning"] = unLog[0].CheminDacces;
                        imagePhotoScanne.Source = ImageSource.FromUri(new Uri("http://109.16.248.248" + unLog[0].CheminDacces));
                  
                    }
                    else
                    {
                        MessageError.Text = "Erreur de Scanne veuillez réesseyer";
                    }
                }
                else
                {
                    MessageError.Text = "OUPS IL SEMBLE QUE TU SOIS LE PROBLEME ";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }



    }

    //permet de binder le chemin d'acces pour afficher la photo 
    public class PageScanViewModel : INotifyPropertyChanged
    {
        string resultatscanning;

        public string CheminDacces
        {
            get { return resultatscanning; }
            set
            {
                if (resultatscanning != value)
                {
                    resultatscanning = value;
                    OnPropertyChanged("CheminDacces");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public PageScanViewModel()
        {


        }

        //permet de rafraichir la page
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var changed = PropertyChanged;
            if (changed != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }


}