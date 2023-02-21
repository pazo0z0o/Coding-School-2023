using FuelStation.Model.Enums;
using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuelStation.Web.Shared.ManagerOnlyDTOs;


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


        public void EmployeeUpperLimitCheck(EmployeeListDTO employee)
        {
           if(employee.EmployeeType.)

        }


        private bool HasPurchasedFuelItems()
        {
            // Query the database to check if the user has purchased fuel items in previous transactions
            return DbContext.Transactions.Any(t => t.Item == Item.Fuel && t.Value >= 20);
        }















    }
}
