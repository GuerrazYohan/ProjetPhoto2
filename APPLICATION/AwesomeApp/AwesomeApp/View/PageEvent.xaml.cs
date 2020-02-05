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
    public partial class PageEvent : ContentPage
    {
        public PageEvent()
        {
            InitializeComponent();
        }
        private void GoPageHome2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }

        private void Envoie_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }
    }
}