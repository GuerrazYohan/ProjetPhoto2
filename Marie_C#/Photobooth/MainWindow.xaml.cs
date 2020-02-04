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
using System.Data.SqlClient;
using Photobooth.Controleur;
using Photobooth.View;

namespace Photobooth
{

    //DaoCompte DaoLogin = new DaoCompte();
    //compte MonCompte = new compte();
    //evenements MesEvenements = new evenements();

    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UC_Login my_Login = new UC_Login();
            Window_Container.Children.Add(my_Login);
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            //if (MonCompte != null && MesEvenements != null)
            //{
            //if(tb_Username.Text = MonCompte.Email && tb_Mdp.Password = MesEvenements.MotDePasseEvent)
            //{

            //}
            //DaoLogin.GetCompte();
            //string Username = MonCompte.Email;
            //string Password = MesEvenements.MotDePasseEvent;

            //string Username = Marie;
            //string Password = 1234;
            //Convert.ToInt32(Username);
            //Convert.ToInt32(Password);

            //if (tb_Username.Text == Username && tb_Mdp.Text == Password)
            //{

            //}
            //}
            Window_Container.Children.Clear();
            UC_Home my_Home = new UC_Home();
            Window_Container.Children.Add(my_Home);
            btn_Login.Visibility = Visibility.Hidden;
        }
    }
}
