using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using AwesomeApp.View;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // This is optional, but provides better layout for the iPhone X 
            On<Xamarin.Forms.PlatformConfiguration.iOS>().SetUseSafeArea(true);
        }



        int count = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }

        //naviguer entre plusieur page
       

        //private void PageOnglet_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Profil());
        //}
        private void GoMenu_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }


    }
}
