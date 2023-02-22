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
using FuelStation.EF.Repositories;


namespace FuelStation.Web.Shared.Services_Logic
{
    public class TransactionHandler 
    {
        public TransactionHandler() { }

        public bool FuelDiscountCheck(TransactionLine transLine)
        {

            if (transLine.Item.ItemType == ItemType.Fuel && transLine.NetValue > 20)
            {
                return true;
            }

            return false;
        }
        public decimal CalculateDiscountValue(TransactionLine transline)
        {
            return transline.DiscountValue = transline.NetValue * transline.DiscountPercent;
        }        

        public decimal CalcTransactionLineTotal(TransactionLine tline)
        {

            return tline.TotalValue = tline.NetValue - tline.DiscountValue;
        }

        public decimal CalcNetValue(TransactionLine transline)
        { return transline.NetValue = transline.Quantity * transline.ItemPrice; }
       
        public bool HasMultipleFuelLines(Transaction transaction)
        {
            return transaction.TransactionLines.Count(x => x.Item.ItemType == ItemType.Fuel) > 1;
        }
        //=========================================================================
        //for posts & edits
        public bool EmployeeUpperLimitCheck(EmployeeType emploType, List<Employee> employees, out string msg)
        {
            bool res = true;
            msg = "Success";
            int maxCashiers = 4;
            int maxManagers = 3;
            int maxStaff = 10;
            var cashiers = employees.Where(emp => emp.EmployeeType == EmployeeType.Cashier);
            var managers = employees.Where(emp => emp.EmployeeType == EmployeeType.Manager);
            var staff = employees.Where(emp => emp.EmployeeType == EmployeeType.Staff);


            if (emploType == EmployeeType.Cashier && cashiers.Count() > maxCashiers)
            {
                msg = $"Exceeded the maximum number of Cashiers allowed. (Max = {maxCashiers})";
                res = false;
            }
            else if (emploType == EmployeeType.Manager && managers.Count() > maxManagers)
            {
                msg = $"Exceeded the maximum number of Managers allowed. (Max = {maxManagers})";
                res = false;
            }
            else if (emploType == EmployeeType.Staff && staff.Count() > maxStaff)
            {
                msg = $"Exceeded the maximum number of Staff allowed. (Max = {maxStaff})";
                res = false;
            }

            return res;

        }
        //for the deletes
        public bool EmployeeLowerLimitCheck(EmployeeType emploType, List<Employee> employees, out string msg)
        {
            bool res = true;
            msg = "Success";
            int minCashiers = 1;
            int minManagers = 1;
            int minStaff = 1;
            var cashiers = employees.Where(emp => emp.EmployeeType == EmployeeType.Cashier);
            var managers = employees.Where(emp => emp.EmployeeType == EmployeeType.Manager);
            var staff = employees.Where(emp => emp.EmployeeType == EmployeeType.Staff);


            if (emploType == EmployeeType.Cashier && cashiers.Count() < minCashiers)
            {
                msg = $"Can't pass the minimum number of Cashiers allowed. (Min = {minCashiers})";
                res = false;
            }
            else if (emploType == EmployeeType.Manager && managers.Count() < minManagers)
            {
                msg = $"Can't pass the minimum number of Managers allowed. (Max = {minManagers})";
                res = false;
            }
            else if (emploType == EmployeeType.Staff && staff.Count() < minStaff)
            {
                msg = $"Can't pass the minimum number of Staff allowed. (Max = {minStaff})";
                res = false;
            }
            return res;
        }


        

        // check if an employee's hire dates are valid -- Do it for Employee not datetime
        public bool HireDatesValid(DateTime hireDateStart, DateTime? hireDateEnd, out string msg)
        {
            msg = "Successfull";
            if (hireDateStart > hireDateEnd)
            {
                msg = "Can't be fired, before even getting hired";
                return false;
            }
            var currentDate = DateTime.Now.Date;
            if (hireDateStart > currentDate || hireDateEnd < currentDate)
            {
                msg = " No future hirings OR past firings allowed";
                return false;
            }

            return true;
        }

        public bool HireDateCheck(DateTime hireStart)
        {
            bool res = true;
            if(hireStart < DateTime.Now) { res = false; }
            return res;
        }

        public bool FiredDateCheck(DateTime hireStart ,DateTime? hireEnd)
        {  bool res = true;
            if (hireEnd < hireStart || hireEnd < DateTime.Now) { res = false; }
            return res;
        }

        public bool CashOnlyOverFifty(Transaction transaction)
        {   
            bool res = false;
            if(transaction.TotalValue > 50) { res = true; }
            return res;            
        }           




      
        public decimal CalculateTotalValue(Transaction transaction)
        {

            decimal totalValue = 0;
            foreach (var trl in transaction.TransactionLines)
            {
                totalValue = trl.NetValue - trl.DiscountValue; 
            }
            return totalValue;
        }


       





      

    }
}
