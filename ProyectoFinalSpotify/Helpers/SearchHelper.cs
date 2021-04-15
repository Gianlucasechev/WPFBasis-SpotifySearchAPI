using ProyectoFinalSpotify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;
using System.Net.Http;
using static ProyectoFinalSpotify.Models.SpotifySearch;

namespace ProyectoFinalSpotify.Helpers
{
    public static class SearchHelper
    {
        public static Token token { get; set; }
        //método para traer al artista o canción
        public static async Task GetTokenAsync()
        {
            //obtener el token
            #region SecretVault
            string clientID = "d6c62bd2908e49a68a29c204b9c716e5";
            string clientSecret = "7af3b3575a264224abfc9f22c380bbfb";
            #endregion
            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes(clientID + ":" + clientSecret));

            List<KeyValuePair<string, string>> args = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("grant_type", "client_credentials")
            };

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", $"Basic {auth}");
            HttpContent content = new FormUrlEncodedContent(args);

            HttpResponseMessage resp = await client.PostAsync("https://accounts.spotify.com/api/token", content);
            string msg = await resp.Content.ReadAsStringAsync();

            token = JsonConvert.DeserializeObject<Token>(msg);
        }
        public static SpotifyResult SearchArtist(string searchWord)
        {
            var client = new RestClient("https://api.spotify.com/v1/search");
            client.AddDefaultHeader("Authorization", $"Bearer {token.access_token}");
            var request = new RestRequest($"?q={searchWord}&type=artist", Method.GET);
            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var result = JsonConvert.DeserializeObject<SpotifyResult>(response.Content);
                return result;
            }
            else
            {
                return null;
            }

        }
    }
}
