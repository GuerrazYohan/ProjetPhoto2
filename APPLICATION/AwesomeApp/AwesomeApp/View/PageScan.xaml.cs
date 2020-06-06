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
using Plugin.DownloadManager.Abstractions;
using Plugin.Share;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageScan : ContentPage
    {
        readonly PageScanViewModel modelScan;
        
        ZXingScannerPage scanPage;

       ZXingBarcodeImageView pageScanner;


        String cheminPhoto = "";
        public string result { get; set; }
        public object CheminDacces { get; private set; }
        public IDownloadFile File;
        bool isDownloading = true;

        public PageScan()
        {
            InitializeComponent();
            modelScan = new PageScanViewModel();
            this.BindingContext = modelScan;
            ButtonScanContinuously.Clicked += ButtonScanContinuously_Clicked;

            CrossDownloadManager.Current.CollectionChanged += (sender, e) =>
            System.Diagnostics.Debug.WriteLine(
                "[DownloadManager]" + e.Action +
                " -> New items: " + (e.NewItems?.Count ?? 0) +
                " at " + e.NewStartingIndex +
                " || Old items: " + (e.OldItems?.Count ?? 0) +
                " at " + e.OldStartingIndex
                );
            
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


                   var Action = await DisplayActionSheet("Scanned Barcode", result.Text, "Cancel", null, "Afficher");

                    switch (Action)
                    {
                        case "Cancel":

                            // Do Something when 'Cancel' Button is pressed

                            break;

                        case "Afficher":

                            await ReachPhoto(result.Text);
                           
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
        public async void DownloadFile(string address)
        {
            //WebClient client = new WebClient();
            //string reply = client.DownloadString(address);
            //Console.WriteLine(reply);

            await Task.Yield();
            //UserDialogs.Instance.ShowLoading("Downloading...",MaskType.Black);
            //await Navigation.PushPopupAsync(new PageScan());
            await Task.Run(() =>
           {

               var downloadManager = CrossDownloadManager.Current;
               var file = downloadManager.CreateDownloadFile(address);
               downloadManager.Start(file, true);

               while (isDownloading)
               {
                   //await Task.Delay(10*200);
                   isDownloading = IsDownloading(file);
               }

           });
            //UserDialogs.Instance.HideLoading();
            //await Navigation.PopAllPopupAsync();
            if (!isDownloading) 
            {
                await DisplayAlert("File Status" , "File Downloded" , "OK");
                //DependencyService.Get<IToast>().ShowToast("Your file has");
            }
            
        }

        public bool IsDownloading(IDownloadFile File)
        {
            //if(TotalBytewritten== File.TotalBytesWritten && File.TotalBytesWritten!=0)
            //{ 
            //  return false;
            //}
            //TotalBytewritten = File.TotalBytesWritten;
            if (File == null) return false;
            switch (File.Status)
            {
                case DownloadFileStatus.INITIALIZED:
                case DownloadFileStatus.PAUSED:
                case DownloadFileStatus.PENDING:
                case DownloadFileStatus.RUNNING:
                    //DependencyService.Get<IToast>().ShowToast();
                    return true;

                case DownloadFileStatus.COMPLETED:
                case DownloadFileStatus.CANCELED:
                case DownloadFileStatus.FAILED:
                    return false;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void AbortDownloading()
        {
            CrossDownloadManager.Current.Abort(File);
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
                        cheminPhoto = "http://109.16.248.248" + unLog[0].CheminDacces;
                        imagePhotoScanne.Source = ImageSource.FromUri(new Uri(cheminPhoto));
                  
                    }
                    else
                    {
                        MessageError.Text = "Erreur de Scanne veuillez réesseyer";
                    }
                }
                else
                {
                    MessageError.Text = "OUPS, il semble qu'il y est un problème avec le serveur";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

        }


        private async void BT_Share_Clic(object sender, EventArgs e)
        {
            await ShareUri(cheminPhoto);

        }
        private void BT_Download_Clic(object sender, EventArgs e)
        { 
           DownloadFile(cheminPhoto);
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