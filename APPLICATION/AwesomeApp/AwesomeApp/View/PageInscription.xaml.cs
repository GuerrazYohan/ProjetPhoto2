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
    public partial class PageInscription : ContentPage
    {
        public PageInscription()
        {
            InitializeComponent();
        }


        private void BT_Retour_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private void BT_AddCompte_Clicked(object sender, EventArgs e)
        {
            AddCompte();
        }

        public async void AddCompte()
        {
            JObject oJsonObject = new JObject();
            oJsonObject.Add("Nom", NomCompte.Text);
            oJsonObject.Add("Prenom", PrenomCompte.Text);
            oJsonObject.Add("Mdp", PassWordCompte.Text);
            oJsonObject.Add("Email", emailCompte.Text);

            //https://forums.xamarin.com/discussion/126833/using-httpclient-postasync-correctly

            var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, "application/json");

            HttpClient Profil = new HttpClient();
            var oTaskPostAsync = await Profil.PostAsync("http://109.16.248.248/WebServiceSlim/Update/CompteWhereEmail", content);

            oTaskPostAsync.StatusCode.ToString();


            if (oTaskPostAsync.IsSuccessStatusCode)
            {
                await DisplayAlert("Hey! Compte Créer", "Tu peux maintenant aller te connecter", "OK");
            }
            else
            {
                await DisplayAlert("Oups un problème est survenue", "Essaye encore !!!", "OK");
            }
        }

    }
}