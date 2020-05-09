using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using AwesomeApp.View;
using AwesomeApp.Model;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            //////On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);


        }

       

        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        //active la fonction ReachLogin
        private void GoMenu_Clicked(object sender, EventArgs e)
        {
            ReachLogin();
            //Navigation.PushAsync(new PageMenu());
        }



        //Fonction pour vérifier que le compte existe bien dans la base de donnée et donner l'acces à l'application
        public async void ReachLogin()
        {
            List<Compte> unLog = new List<Compte>();
            if ((inputemail.Text != null) && (inputPassword.Text != null) && (inputemail.Text != "") && (inputPassword.Text != ""))
            {
                try
                {
                    HttpClient client = new HttpClient();
                    var uri = new Uri("http://109.16.248.248/WebServiceSlim/Get/Login");


                    JObject oJsonObject = new JObject
                    {
                        {"Email", inputemail.Text.ToString()},
                        {"MotDePasse", inputPassword.Text.ToString()}
                    };

                    

                    var reponse = await client.PostAsync(uri, new StringContent(oJsonObject.ToString(), Encoding.UTF8, "application/json"));

                    if (reponse.IsSuccessStatusCode)
                    {
                        string content = await reponse.Content.ReadAsStringAsync();
                        if (!content.Equals("[]"))
                        {
                            unLog = JsonConvert.DeserializeObject<List<Compte>>(content);
                            MessageError.Text = null;
                            Application.Current.Properties["nom"] = unLog[0].Nom;
                            Application.Current.Properties["prenom"] = unLog[0].Prenom;
                            Application.Current.Properties["email"] = unLog[0].Email;
                            Application.Current.Properties["motdepasse"] = unLog[0].MotDePasse;
                            await Navigation.PushAsync(new PageMenu());
                        }
                        else
                        {
                            MessageError.Text = "Erreur de connexion vérifier vos identifiants et mot de passe";
                        }
                    }
                    else
                    {
                        MessageError.Text = "Erreur de connexion vérifier vos identifiants et mot de passe";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
            else
            {
                MessageError.Text = "Veuillez remplire tout les champs";
            }


        }
    }
}

