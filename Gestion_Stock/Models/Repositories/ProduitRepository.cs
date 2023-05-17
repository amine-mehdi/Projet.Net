namespace Gestion_Stock.Models.Repositories
{
    public class ProduitRepository : IGestionStockRepository<Produit>
    {
        IList<Produit> Produits;
        public ProduitRepository()
        {
            Produits = new List<Produit>()
            {
                new Produit{Id=new Guid(), Nom="ordinateur", Quantite="1", Prix="570,2"},
                new Produit{Id=new Guid(), Nom="pc", Quantite="2", Prix="400,2"},
                new Produit{Id=new Guid(), Nom="telephone", Quantite="10", Prix="600"},

            };
        }
        public void Add(Produit entity)
        {
            Produits.Add(entity);
        }

        public void Delete(Guid id)
        {
           var Produit = Find(id);
            Produits.Remove(Produit);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Produit Find(Guid id)
        {
            var Produit = Produits.SingleOrDefault(a => a.Id == id);

            return Produit;
        }

        public object Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Produit> list()
        {
            return Produits;
        }

        public void Update(Guid Id, Produit newProduit)
        {
            var Produit = Find(Id);
            Produit.Nom= newProduit.Nom;
        }
    }
}
