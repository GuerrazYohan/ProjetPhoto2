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

using EOSDigital.API;
using EOSDigital.SDK;

namespace Photobooth
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        UC_Login Connect;
        UC_Photo Photo;
        DaoCompte DaoLogin = new DaoCompte();
        compte MonCompte = new compte();
        evenements MesEvenements = new evenements();

        CanonAPI APIHandler;
        Camera MainCamera;
        CameraValue[] AvList;
        CameraValue[] TvList;
        CameraValue[] ISOList;
        List<Camera> CamList;
        bool IsInit = false;
        int BulbTime = 30;
        ImageBrush bgbrush = new ImageBrush();
        Action<BitmapImage> SetImageAction;

        int ErrCount;
        object ErrLock = new object();

        public MainWindow()
        {
            Connect = new UC_Login();
            Photo = new UC_Photo();

            InitializeComponent();
            UC_Login my_Login = new UC_Login();
            Window_Container.Children.Add(my_Login);
            btn_Login.Visibility = Visibility.Visible;
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            
            DaoLogin.GetCompte();
            /*
            if (MonCompte != null && MesEvenements != null)
            {
                if (Connect.tb_Username.Text == MonCompte.Email)
                {
                    if (Connect.tb_Mdp.Password == MesEvenements.MotDePasseEvent)
                    {
                        Window_Container.Children.Clear();
                        UC_Home my_Home = new UC_Home();
                        Window_Container.Children.Add(my_Home);
                        btn_Login.Visibility = Visibility.Hidden;
                        btn_Start.Visibility = Visibility.Visible;
                        lb_Title.Content = "Bienvenue " + MonCompte.Prenom;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username");
                }
            }
            else
            {
                MessageBox.Show("Il n'y as aucun évenements de créer !");
            }*/
            Window_Container.Children.Clear();
            UC_Home my_Home = new UC_Home();
            Window_Container.Children.Add(my_Home);
            btn_Login.Visibility = Visibility.Hidden;
            btn_Start.Visibility = Visibility.Visible;
            lb_Title.Content = "Bienvenue " + MonCompte.Prenom;
        }


        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            Window_Container.Children.Clear();
            btn_Login.Visibility = Visibility.Hidden;
            btn_Start.Visibility = Visibility.Hidden;
            UC_Photo my_Photo = new UC_Photo();
            Window_Container.Children.Add(my_Photo);





            ////Met le fond du LVCanvas comme étant le live preview de la caméra
            //Photo.LVCanvas.Background = bgbrush;
            //MainCamera.StartLiveView();
                
                
            
        }

        
    }
}
