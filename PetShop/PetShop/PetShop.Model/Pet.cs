﻿using PetShop.Model.Enums;

namespace PetShop.Model
{
    public class Pet
    {
        public Pet(string breed, AnimalType animalType, PetStatus petStatus, decimal price, decimal cost)
        {
            Breed = breed;
            AnimalType = animalType;
            PetStatus = petStatus;
            Price = price;
            Cost = cost;

            TransactionLines = new TransactionLine();
        }

        public int Id { get; set; }
        public string Breed { get; set; }
        public AnimalType AnimalType { get; set; }
        public PetStatus PetStatus { get; set; }
        public decimal Price { get; set; }
        public decimal Cost { get; set; }

        // Relations
        
        public TransactionLine TransactionLines { get; set; } = new();
    }
}
