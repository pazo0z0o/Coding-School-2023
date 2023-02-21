using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Web.Shared.ManagerOnlyDTOs;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using Microsoft.EntityFrameworkCore;


namespace FuelStation.Web.Shared.Services_Logic
{
    public class TransactionHandler
    {


        public bool FuelDiscountCheck(TransactionLine transLine)
        {
            if (transLine.Item.ItemType == ItemType.Fuel && transLine.NetValue > 20)
            {
                return true;
            }

            return false;
        }


     /*   public void EmployeeUpperLimitCheck(Employee employee)
        {


        }*/


        /*public void EmployeeUpperLimitCheck(EmployeeListDTO employee)
        {
           if(employee.EmployeeType.)

        }*/


       // private bool HasPurchasedFuelItems(Transaction trans )
       // {
            // Query the database to check if the user has purchased fuel items in previous transactions
           // return Transactions.Any(t => t.Item == Item.Fuel && t.Value >= 20);
       // }

        /*public bool HasFuel(Transaction transaction, TransactionEditDTO transaction)
        {
            if (transaction.FindAll(x => x. == transaction.CarId).Count == 0 || // checks if theres an existing transaction with customer or car inserted.
                transactionList.FindAll(x => x.CustomerId == transaction.CustomerId).Count == 0) { return true; }
            return false;
        }*/

        public bool HasMultipleFuelLines(Transaction transaction)
        {
            return transaction.TransactionLines.Count(x => x.Item.ItemType == ItemType.Fuel) > 1;
        }

// check if an employee's hire dates are valid -- Do it for Employee not datetime
	public bool AreHireDatesValid(DateTime hireDateStart, DateTime hireDateEnd)
	{
    if (hireDateStart > hireDateEnd)
    {
        return false;
    }

    var currentDate = DateTime.Now.Date;
    if (hireDateStart > currentDate || hireDateEnd < currentDate)
    {
        return false;
    }

    return true;
	}
        //needs modifications
        public decimal CalculateTotalValue(Transaction transaction)
        {

            decimal totalCost = 0;
            foreach (var trl in transaction.TransactionLines)
            {
               // totalCost += trl.ServiceTask.Hours * _workhour;
            }
            return totalCost;
        }


        // check if an item code is unique - do it for Items
        /* public bool IsItemCodeUnique(Item itemCode)
         {
             if (itemCode == null)
             {
                 return false;
             }

             var existingItem = Item.FirstOrDefault(i => i.Code == itemCode);
             return existingItem == null;
         }


         // check if a customer card number is unique and starts with 'A'
         public bool IsCustomerCardNumberValid(Customer customer)
         {
             if (customer.CardNumber == null || customer.CardNumber.Length < 2 || customer.CardNumber[0] != 'A')
             {
                 return false;
             }

             var existingCustomer = _context.Customers.FirstOrDefault(c => c.CardNumber == customer.CardNumber);
             return existingCustomer == null;
         }
 */


    }
}
