using Gestion_Stock.Models;

namespace Gestion_Stock.ViewModels
{
    public class ProduitClientViewModel
    {
        public Guid ProduitId { get; set; }
        public string Nom { get; set; }
        public string Quantite { get; set; }
        public string prix { get; set; }
        public Guid ClientId{ get; set; }
        public List<Client> Clients { get; set; }
    }
}
