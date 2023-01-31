using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models
{
    public enum AnimalType
    {
        Dog,
        Cat,
        Parrot,
        Rodent,
        Serpent,
        Fish
    }

    public enum PetStatus
    {
        OK,
        Unhealthy,
        Recovering
    }

    public class Pet
    {
        public AnimalType Animaltype { get; set; }

        public PetStatus Petstatus { get; set; }

        public Guid PetID { get; set; }

        public string? Breed { get; set; }

        public decimal Price { get; set; }

        public decimal Cost { get; set; }

        //public DateTime Bought { get; set; }

        // public Guid? TransactionID { get; set; }
        //===================================================
        public Transactions Transacts { get; set; }


        public Pet() { PetID = Guid.NewGuid(); }
        public Pet(string breed, AnimalType animaltype, decimal price, decimal cost, PetStatus petstatus)
        {
            PetID = Guid.NewGuid();
            //DateTime dt = new DateTime(1990, 1, 1);
            //Bought = dt;
            //TransactionID = Guid.Empty;
            Animaltype = animaltype;
            //TransactionID = Guid.Empty;
            Price = price;
            Cost = cost;
            Petstatus = petstatus;
            Breed = breed;


        }
    }
}
