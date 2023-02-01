using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models.Populate_Classes
{
    internal class PopulateCustomer
    {

        public List<Customers> Customers { get; set; }
        public PopulateCustomer() { }

        //Customer(ID, Name, Surname, Phone, TIN)

        public List<Customers> PopulateCustomers()
        {
            Customers = new List<Customers>(); Guid id = Guid.Parse("{E02ACE2B-6B49-49B6-8BB4-D0CBE5ECA72A}");
            int randomUpper = 999999999;
            int randomLower = 000000001;

            Customers customer;

            customer = new Customers("John", "Papajohn", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Charis", "Charoulis", "175-124-56", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Zisis", "Zisakos", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Kostas", "Mitrogol", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Panos", "Korgialas", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Betty", "Tzanabetty", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Kiki", "Chainoglou", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Katerina", "Papoutsaki", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Margarita", "Margarw", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Kostas", "Prekas", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Rita", "Ritaki", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Petros", "Petran", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Tasos", "Stotoglou", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Christos", "Christakis", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Makis", "Dimakis", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Nikitas", "Avramopoulos", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Marina", "Marteli", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Marios", "Marinos", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Mitsos", "Karamanlis", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Filos", "Filou", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);

            customer = new Customers("Paris", "Pateras", "555-555-55", RandomTin(randomLower, randomUpper));
            Customers.Add(customer);


            //bsCustomer.DataSource = Customers;
            return Customers;
        }

        public int RandomTin(int lower, int upper)
        {
            var random = new Random();
            int number = random.Next(lower, upper);
            return number;
        }


































    }
}
