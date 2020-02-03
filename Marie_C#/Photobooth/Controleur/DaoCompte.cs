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
    class DaoCompte
    {
        private photoboothproject_2020Entities context;

        ////////////READ///////////
        public IEnumerable<object> GetCompte()
        {
            using (context = new photoboothproject_2020Entities())
            {
                var MonCompte = (from d in context.compte select d).ToList();
                return MonCompte;
            }
        }
    }
}
