using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient ;
using Photobooth.Controleur;
using Photobooth.View;

namespace Photobooth.View
{
    /// <summary>
    /// Logique d'interaction pour UC_Login.xaml
    /// </summary>
    public partial class UC_Login : UserControl
    {
        DaoCompte DaoLogin = new DaoCompte();
        compte MonCompte = new compte();
        evenements MesEvenements = new evenements();
        public UC_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {  
            if(MonCompte != null && MesEvenements != null)
            {
                //if(tb_Username.Text = MonCompte.Email && tb_Mdp.Password = MesEvenements.MotDePasseEvent)
                //{

                //}
                DaoLogin.GetCompte();
                string Username = MonCompte.Email;
                string Password = MesEvenements.MotDePasseEvent;
                Convert.ToInt32(Username);
                Convert.ToInt32(Password);

                if(tb_Username.Text == Username && tb_Mdp.Text == Password)
                {
                    Login_Grid.Visibility = Visibility.Hidden;
                }
            }
        }

       
    }
}
