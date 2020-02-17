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
            btn_Login.Visibility = Visibility.Visible;
        }

        private void Btn_Login_Click(object sender, RoutedEventArgs e)
        {
            Window_Container.Children.Clear();
            UC_Home my_Home = new UC_Home();
            Window_Container.Children.Add(my_Home);
            btn_Login.Visibility = Visibility.Hidden;
            btn_Start.Visibility = Visibility.Visible;
            lb_Title.Content = "Bienvenue";
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            Window_Container.Children.Clear();
            //UC_Home my_Home = new UC_Home();
            //Window_Container.Children.Add(my_Home);
            btn_Login.Visibility = Visibility.Hidden;
            btn_Start.Visibility = Visibility.Hidden;
            UC_Photo my_Photo = new UC_Photo();
            Window_Container.Children.Add(my_Photo);
        }
        
    }
}
