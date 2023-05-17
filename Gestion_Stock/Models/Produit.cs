namespace Gestion_Stock.Models
{
    public class Produit
    {
        public Guid Id { get; set; }
        public string Nom { get; set; }
        public string Quantite { get; set; }
        public string Prix { get; set;}
        public Client Client { get; set;}

        
    }
}
