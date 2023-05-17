using Gestion_Stock.Models;
using Gestion_Stock.Models.Repositories;
using Gestion_Stock.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_Stock.Controllers
{
    public class ProduitController : Controller
    {
        private IGestionStockRepository<Produit> ProduitRepository;
        private readonly IGestionStockRepository<Client> clientRepository;

        public ProduitController(IGestionStockRepository<Produit> ProduitRepository,IGestionStockRepository<Client>ClientRepository)
        {
            this.ProduitRepository = ProduitRepository;
            clientRepository = ClientRepository;
        }
        // GET: ProduitController
        public ActionResult Index()
        {
            var produits = ProduitRepository.list();
            return View(produits);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(Guid id)
        {
            var produit =ProduitRepository.Find(id);
            return View(produit);
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            var model = new ProduitClientViewModel
            {
                Clients = clientRepository.list().ToList()

            };
            return View(model);
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProduitClientViewModel model)
        {
            try
            {
                var client = clientRepository.Find(model.ClientId);
                Produit produit = new Produit
                {
                    Id = new Guid(),
                    Nom = model.Nom,
                    Quantite = model.Quantite,
                    Prix = model.prix,
                    Client = client

                };
                ProduitRepository.Add(produit);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PrduitController/Edit/5
        public ActionResult Edit(Guid id)
        {
            Produit produit = (Produit)ProduitRepository.Find(id);
            var viewModel = new ProduitClientViewModel
            {



                ProduitId = produit.Id,
                Nom = produit.Nom,
                Quantite = produit.Quantite,
                prix = produit.Prix,
                ClientId = produit.Client.Id,
                Clients = clientRepository.list().ToList()


            };
            return View(viewModel);
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
