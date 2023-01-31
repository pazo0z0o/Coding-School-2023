using Microsoft.EntityFrameworkCore;
using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.PetShop.Orm.Repositories
{
    public class PetRepo : IEntity<Pet>
    {
        public void Add(Pet entity)
        {
            using var context = new AppDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Pets.Where(pets => pets.PetID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            context.Remove(dbPetShop);
            context.SaveChanges();
        }

        public IList<Pet> GetAll()
        {
            using var context = new AppDbContext();
            return context.Pets.Include(pets => pets.Transacts).ToList();

        }

        public Pet? GetById(Guid id)
        {
            using var context = new AppDbContext();
            return context.Pets.Where(pets => pets.PetID == id).Include(pets => pets.Transacts).SingleOrDefault();
        }

        public void Update(Guid id, Pet entity)
        {
            using var context = new AppDbContext();
            var dbPetShop = context.Pets.Where(emps => emps.PetID == id).SingleOrDefault();
            if (dbPetShop is null)
                return;
            dbPetShop.Petstatus = entity.Petstatus;
            dbPetShop.Animaltype = entity.Animaltype;
            dbPetShop.Breed = entity.Breed;
            dbPetShop.Price = entity.Price;
            dbPetShop.Cost = entity.Cost;
            dbPetShop.Transacts = entity.Transacts;
            context.SaveChanges();
        }
    }
}

/*public AnimalType Animaltype { get; set; }
public PetStatus Petstatus { get; set; }
public Guid PetID { get; set; }
public string? Breed { get; set; }
public decimal Price { get; set; }
public decimal Cost { get; set; }
*/