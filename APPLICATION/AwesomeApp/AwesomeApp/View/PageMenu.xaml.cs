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

        private void GoEvent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageEvent());
        }

        private void GoProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageProfil());
        }

        private void GoScan_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageScan());
        }

        private void GoDeco_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }
    }
}