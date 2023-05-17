namespace Gestion_Stock.Models.Repositories
{
    public class ClientsRepository : IGestionStockRepository<Client>
    {
        List<Client> Clients;
        public ClientsRepository()
        {
            Clients = new List<Client>()
            {
                new Client
                {
                    Id= new Guid("e04a5f68-472c-4a3b-aa45-5adcabd74e05"), Nom="Mehdi", Prenom="Mohamed amine", Email="aminemehdi@gmail.com", Telephone=29344473, Ville="kef", Pays="Tunis"
                },
                new Client
                {
                    Id= new Guid("b47f0cf1-00a2-4864-8026-043c6fa8d185"), Nom="Mejri", Prenom=" Raed", Email="Raedmejri@gmail.com", Telephone=12345678, Ville="tbarka", Pays="Tunis"
                },
                new Client
                {
                    Id= new Guid("5306707b-d81b-4d48-aae7-11b89264f876"), Nom="Mehdi", Prenom=" Seif", Email="Seifmehdi@gmail.com", Telephone=23456789, Ville="kef", Pays="Tunis"
                },

            };
        }

        public void Add(Client entity)
        {
            Clients.Add(entity);
        }

        public void Delete(Guid id)
        {
            var client = Find(id);
            Clients.Remove(client);
        }

        

        public Client Find(Guid id)
        {
            var client = Clients.SingleOrDefault(c => c.Id==id) ;
            return client;
        }

      

        public IList<Client> list()
        {
            return Clients;
        }

        public void Update(Guid Id, Client newClient)
        {
            var client = Clients.SingleOrDefault(x => x.Id == Id);
            client.Nom = newClient.Nom;
            Clients.Add(client);


        }
    }
}
