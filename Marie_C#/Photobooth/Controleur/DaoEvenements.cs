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
    class DaoEvenements
    {
        private photoboothproject_2020Entities context;
        public IEnumerable<object> GetEvenements()
        {
            using (context = new photoboothproject_2020Entities())
            {
                var MesEvenement = (from d in context.evenements select d).ToList();
                return MesEvenement;
            }
        }
    }
}
