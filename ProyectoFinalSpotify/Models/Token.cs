
namespace ProyectoFinalSpotify.Models
{
    public class Token
    {
        //El consumo de este API requiere un Token
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
    }
}
