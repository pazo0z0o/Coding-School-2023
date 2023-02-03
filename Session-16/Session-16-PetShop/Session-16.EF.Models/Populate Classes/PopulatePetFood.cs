using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_16.EF.Models.Populate_Classes
{
    public class PopulatePetFood
    {

        public PopulatePetFood()
        {

        }

/*        public list<petfood> populatepetfoods()
        {

            list<petfood> petfood = new list<petfood>();
            int transactionnumber = 30;
            datetime date;
            decimal qty;
            petfood pf;

            populate
            foreach (animaltype type in enum.getvalues(typeof(animaltype)))
            {
                pf = new petfood(type, randompricecost(2, 5), randompricecost(7, 12));
                date = randomdate();
                qty = randomqty();

                petshoptransactions - how many the petshop bought(not customer)
                for (int i = 0; i < transactionnumber; i++)
                {
                    pf.petfoodtransactions.add(new petfoodtransaction(date, qty));
                }
                pf.setqty();
                petfood.add(pf);
            }
            return petfood;
        }

        public decimal randompricecost(int lower, int upper)
        {
            var random = new random();
            int number = random.next(lower, upper);
            return number;
        }


        random quantity for petfoodtransactions
        public decimal randomqty()
        {
            var random = new random();
            int employee = random.next(20, 60);
            return employee;
        }
        random date for petfoodtransactions
        public datetime randomdate()
        {
            random gen = new random();
            datetime start = new datetime(2022, 1, 1);
            int range = ((timespan)(datetime.today - start)).days;
            return start.adddays(gen.next(range));
        }*/
    }
}