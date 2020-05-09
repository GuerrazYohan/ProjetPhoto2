using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeApp.View;
using AwesomeApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using Xamarin.Essentials;
using System.IO;
using System.Net.NetworkInformation;
using System.Collections.ObjectModel;
using System.Collections;
using RestSharp;
using Newtonsoft.Json.Linq;
using System.ComponentModel;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProfil : ContentPage
    {
        readonly PageProfilViewModel model;
        
        public PageProfil()
        {

            InitializeComponent();
            model = new PageProfilViewModel();
            this.BindingContext = model;
          

        }

     
        // Bouton pour modifier le compte
        private async void Modifier_Clicked(object sender, EventArgs e)
        {
            UpdatedProfil();

        }

        // Fonction pour modifier le profil
        public async void UpdatedProfil()
        {

            JObject oJsonObject = new JObject();
            oJsonObject.Add("Nom", NomProfil.Text);
            oJsonObject.Add("Prenom", PrenomProfil.Text);
            oJsonObject.Add("Mdp", PassWordProfil.Text);
            oJsonObject.Add("Email", emailProfil.Text);

            //https://forums.xamarin.com/discussion/126833/using-httpclient-postasync-correctly

            var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, "application/json");

            HttpClient Profil = new HttpClient();
            var oTaskPostAsync = await Profil.PostAsync("http://109.16.248.248/WebServiceSlim/Update/CompteWhereEmail", content);

            oTaskPostAsync.StatusCode.ToString();


            if (oTaskPostAsync.IsSuccessStatusCode)
            {
                await DisplayAlert("Hey! Compte modifier", "Cancel", "OK");
            }
            else
            {
                await DisplayAlert("Oups un problème est survenue", "Cancel", "OK");
            }


        }

        //retour à la page menu
        private void GoMainpage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }
    }

    //Afficher les donnees d'un profil connecter 
    public class PageProfilViewModel : INotifyPropertyChanged
    {
        string nom;
        public string Nom
        {
            get { return nom; }
            set
            {
                if (nom != value)
                {
                    nom = value;
                    OnPropertyChanged("Nom");
                }
            }
        }
        string prenom;
        public string Prenom
        {
            get { return prenom; }
            set
            {
                if (prenom != value)
                {
                    prenom = value;
                    OnPropertyChanged("prenom");
                }
            }
        }
        string email;
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    OnPropertyChanged("Email");
                }
            }
        }

        string motdepasse;
        public string MotDePasse
        {
            get { return motdepasse; }
            set
            {
                if (motdepasse != value)
                {
                    motdepasse = value;
                    OnPropertyChanged("MotDePasse");
                }
            }
        }

        public PageProfilViewModel()
        {
            Nom = Application.Current.Properties["nom"].ToString();
            Prenom = Application.Current.Properties["prenom"].ToString();
            Email = Application.Current.Properties["email"].ToString();
            MotDePasse = Application.Current.Properties["motdepasse"].ToString();
        }
        public event PropertyChangedEventHandler PropertyChanged;

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