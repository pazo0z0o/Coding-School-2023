using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.MVC.Models.Pet;
using System.Drawing;

namespace PetShop.MVC.Controllers
{
    public class PetController : Controller
    {

        private readonly IEntityRepo<Pet> _petRepo;
        private readonly IEntityRepo<Transaction> _transactionRepo;
        // GET: PetController
        public PetController(IEntityRepo<Pet> petRepo, IEntityRepo<Transaction> transactionRepo)
        {
            _transactionRepo = transactionRepo;
            _petRepo = petRepo;
        }

        public ActionResult Index()
        {
            var pet = _petRepo.GetAll().ToList();
            return View(model: pet);
        }

        // GET: PetController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var pet = _petRepo.GetById(id);
            if (pet == null) return NotFound();

            var viewPet = new PetDetailsDTO()
            {
                Id = pet.Id,
                Breed = pet.Breed,
                AnimalType = pet.AnimalType,
                PetStatus = pet.PetStatus,
                Price = pet.Price,
                Cost = pet.Cost
            };
            return View(model: viewPet);
        }

        // GET: PetController/Create
        public ActionResult Create()
        {
            var newPet = new PetCreateDTO();
            //var transations = _transactionRepo.GetAll();
            //how would I put transactions here?
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetCreateDTO pt)
        {
            if (!ModelState.IsValid) return View();

            var dbPet = new Pet( pt.Breed, pt.AnimalType, pt.PetStatus, pt.Price, pt.Cost);

            _petRepo.Add(dbPet);
            return RedirectToAction("Index");
        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int? id)
        {
            var dbPet = _petRepo.GetById(id);
            if(dbPet == null) return NotFound();

            var viewPet = new PetEditDTO()
            {
                Id = dbPet.Id,
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost
            };

            return View( model: viewPet);
        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PetEditDTO pt)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbPet = _petRepo.GetById(id);
            if (dbPet == null) return NotFound();

            dbPet.Breed = pt.Breed;
            dbPet.AnimalType = pt.AnimalType;
            dbPet.PetStatus = pt.PetStatus;
            dbPet.Price = pt.Price;
            dbPet.Cost = pt.Cost;

            _petRepo.Update(id,dbPet);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbPet = _petRepo.GetById(id);
            if (dbPet == null) return NotFound();

            var viewPet = new PetDeleteDTO()
            {
                Id = dbPet.Id,
                Breed = dbPet.Breed,
                AnimalType = dbPet.AnimalType,
                PetStatus = dbPet.PetStatus,
                Price = dbPet.Price,
                Cost = dbPet.Cost
            };

            return View(viewPet);

        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            _petRepo.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
