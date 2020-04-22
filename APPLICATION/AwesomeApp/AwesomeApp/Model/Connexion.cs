using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;

namespace AwesomeApp.Model
{
   public class Connexion
    {
       static readonly HttpClient WebService = new HttpClient();

        public async Task<string> ServiceConnexion(string request)
        {
            try
            {
                string reponse = await WebService.GetStringAsync(request);
                return reponse;
            }
            catch(HttpRequestException)
            {
                return "Erreur de Connexion";
            }
        }
    }
}
