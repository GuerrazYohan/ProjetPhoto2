using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageMenu : ContentPage
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        //Bouton pour aller à la page Commentaire
        private void GoEvent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageEvent());
        }

        //Bouton pour aller à la page Profil
        private void GoProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageProfil());
        }

        //Bouton pour aller à la page Scan
        private void GoScan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageScan());
        }

        //Bouton pour aller à la page Login
        private void GoDeco_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}