namespace Gestion_Stock.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; } 
        public string Email{ get; set; }
        public int Telephone { get; set; }
        public string Ville { get; set; }  
        public string Pays{ get; set; }

    }
}
