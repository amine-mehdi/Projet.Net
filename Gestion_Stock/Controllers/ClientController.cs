using Gestion_Stock.Models;
using Gestion_Stock.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gestion_Stock.Controllers
{
    public class ClientController : Controller
    {
        private readonly IGestionStockRepository<Client> clientRepository;

        public ClientController(IGestionStockRepository<Client> clientRepository)
        {
            this.clientRepository = clientRepository;
        }
        // GET: ClientController1
        public ActionResult Index()
        {
            var Clients = clientRepository.list();
            return View(Clients);
        }

        // GET: ClientController1/Details/5
        public ActionResult Details(Guid id)
        {
            var client = clientRepository.Find(id);

            return View(client);
        }

        // GET: ClientController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Client client)
        {
            try
            {
                clientRepository.Add(client); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController1/Edit/5
        public ActionResult Edit(Guid id)
        {
            var client = clientRepository.Find(id); 
            return View(client);
        }

        // POST: ClientController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Guid id, Client client)
        {
            try
            {
                clientRepository.Update(id, client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientController1/Delete/5
        public ActionResult Delete(Guid id)
        {
            var client = clientRepository.Find(id); 
            return View(client);
        }

        // POST: ClientController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, Client client)
        {
            try
            {
                clientRepository.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
