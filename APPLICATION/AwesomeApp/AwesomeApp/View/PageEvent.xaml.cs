using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageEvent : ContentPage
    {
        public PageEvent()
        {
            InitializeComponent();
        }

        //Retour page menu
        private void GoPageHome2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

        //Envoyer le commentaire en appellant la fonction EnvoyerCommentaire
        private void Envoie_Clicked(object sender, EventArgs e)
        {
           
            EnvoyerCommantaire();
        }

        //Envoyer un commentaire dans la base de donnée
        public async void EnvoyerCommantaire()
        {

            JObject oJsonObject = new JObject();
            oJsonObject.Add("Email", Application.Current.Properties["email"].ToString());
            oJsonObject.Add("Comm", zoneComment.Text);
            

            var content = new StringContent(oJsonObject.ToString(), Encoding.UTF8, "application/json");

            HttpClient Profil = new HttpClient();
            var oTaskPostAsync = await Profil.PostAsync("http://109.16.248.248/WebServiceSlim/Insert/CommWithIdcompte", content);

            oTaskPostAsync.StatusCode.ToString();


            if (oTaskPostAsync.IsSuccessStatusCode)
            {
                await DisplayAlert("Hey! Commantaire Poster", "Génial", "OK");
            }
            else
            {
                await DisplayAlert("Oups un problème est survenue", "ERROR!!!", "OK");
            }


        }

    }

}