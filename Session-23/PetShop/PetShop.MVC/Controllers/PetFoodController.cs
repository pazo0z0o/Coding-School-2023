using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShop.EF.Repositories;
using PetShop.Model;
using PetShop.Model.Enums;
using PetShop.MVC.Models.PetFood;

namespace PetShop.MVC.Controllers
{
    public class PetFoodController : Controller
    {
        private readonly IEntityRepo<PetFood> _petFoodRepo;
        private readonly IEntityRepo<TransactionController> _transactionRepo;
        // GET: PetFoodController

        public PetFoodController(IEntityRepo<PetFood> petFoodRepo, IEntityRepo<TransactionController> transactionRepo)
        {
            _petFoodRepo = petFoodRepo;
            _transactionRepo = transactionRepo;
        
        }
        public ActionResult Index()
        {
            var petfood = _petFoodRepo.GetAll().ToList();
            return View(model: petfood);
       
        }

        // GET: PetFoodController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null) return NotFound();

            var pf = _petFoodRepo.GetById(id);
            if (pf == null) return NotFound();

            var viewPetFood = new PetFoodDetailsDTO()
            {
            Id = pf.Id,
            AnimalType = pf.AnimalType,
            Price = pf.Price,
            Cost = pf.Cost,
            
            Transactions = pf.Transactions
            };

            return View(viewPetFood);
        }

        // GET: PetFoodController/Create
        public ActionResult Create()
        {
            var newPF = new PetFoodCreateDTO();
            return View();

        }

        // POST: PetFoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PetFoodCreateDTO pf)
        {
            if (!ModelState.IsValid) return View();

            var dbPetFood = new PetFood(pf.AnimalType,pf.Price,pf.Cost);

            _petFoodRepo.Add(dbPetFood);
            return RedirectToAction("Index");
        }

        // GET: PetFoodController/Edit/5
        public ActionResult Edit(int? id)
        {
            var dbPetFood = _petFoodRepo.GetById(id);
            if(dbPetFood == null) return NotFound();

            var viewPetFood = new PetFoodEditDTO()
            {   Id = dbPetFood.Id,
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost
            };
            return View(viewPetFood);
        }

        // POST: PetFoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,PetFoodEditDTO pf)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null) return NotFound();

            dbPetFood.AnimalType = pf.AnimalType;
            dbPetFood.Price = pf.Price; 
            dbPetFood.Cost = pf.Cost;

            _petFoodRepo.Update(id, dbPetFood);
            return RedirectToAction(nameof(Index));
        }

        // GET: PetFoodController/Delete/5
        public ActionResult Delete(int id)
        {
            var dbPetFood = _petFoodRepo.GetById(id);
            if (dbPetFood == null) return NotFound();

            var viewPetFood = new PetFoodDeleteDTO()
            {
                Id = dbPetFood.Id,
                AnimalType = dbPetFood.AnimalType,
                Price = dbPetFood.Price,
                Cost = dbPetFood.Cost
            };

            return View(viewPetFood);
        }
        // POST: PetFoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
                _petFoodRepo.Delete(id);
                return RedirectToAction(nameof(Index));
        }
    }
}
