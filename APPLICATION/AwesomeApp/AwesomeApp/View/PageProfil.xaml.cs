using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeApp.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AwesomeApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageProfil : ContentPage
    {
        public PageProfil()
        {
            InitializeComponent();
        }

        private void Modifier_Clicked(object sender, EventArgs e)
        {

        }

        private void GoMainpage2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMenu());
        }
    }
}