using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections;
using System.Data.Entity;

namespace Photobooth.Controleur
{
    class DaoConnection
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public DaoConnection(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        } 
    }
}
