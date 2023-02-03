using Session_16.EF.Models;
using Session_16.EF.PetShop.Orm.Repositories;
using Session16.EF.PetShop.Orm.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Pdf.Native.BouncyCastle.Utilities.Collections;
using DevExpress.CodeParser;

namespace Session_16_PetShop
{
    public partial class Form2 : Form
    {
//       /* public Session_16.EF.Models.PetShop petShop = new Session_16.EF.Models.PetShop();
//        public EngagePopulate ep = new EngagePopulate();
//*/
        

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //InitPetShop(ep);
            SetControlProperties();
        }

        private void SetControlProperties()
        {
            setupCustomerRepo();
            setupEmployeesRepo();
            setupPetsRepo();
            setupPetFoodsRepo();

        }

        //public Session_16.EF.Models.PetShop InitPetShop(EngagePopulate eps) { return petShop = ep.SetPopulation(); }




        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            CustomersRepo customerRepo = new CustomersRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());

            if (customerRepo.GetById(id) is null)
            {
                customerRepo.Add((Customers)bsCustomers.Current);

            }
        }
        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            CustomersRepo customerRepo = new CustomersRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());

            customerRepo.Update(id, (Customers)bsCustomers.Current);
        }
        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            CustomersRepo customerRepo = new CustomersRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());
            customerRepo.Delete(id);
        }
        //==============================Employees===================================================
        private void gdEmployees_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            EmployeesRepo emplRepo = new EmployeesRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colEmpID).ToString());

            if (emplRepo.GetById(id) is null)
            {
                emplRepo.Add((Employees)bsEmployees.Current);
            }
        }
        private void gdEmployees_RowUpdated(object sender, RowObjectEventArgs e)
        {
            EmployeesRepo emplRepo = new EmployeesRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colEmpID).ToString());

            emplRepo.Update(id, (Employees)bsEmployees.Current);
        }

        private void gdEmployees_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            EmployeesRepo emplRepo = new EmployeesRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colEmpID).ToString());
        
            emplRepo.Delete(id);
        }

        //==============================Pets========================================================
        private void grdPets_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            PetRepo petRepo = new PetRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetID).ToString());

            if (petRepo.GetById(id) is null)
            {
                petRepo.Add((Pet)bsPets.Current);
            }
        }
        private void grdPets_RowUpdated(object sender, RowObjectEventArgs e)
        {
            PetRepo petRepo = new PetRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetID).ToString());

            petRepo.Update(id, (Pet)bsPets.Current);

        }

        private void grdPets_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            PetRepo petRepo = new PetRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetID).ToString());

            petRepo.Delete(id);
        }

        //==============================Pet Foods===================================================
        private void PetFood_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            PetFoodRepo petfoodRepo = new PetFoodRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID).ToString());

            if (petfoodRepo.GetById(id) is null)
            {
                petfoodRepo.Add((PetFood)bsPetFood.Current);
            }
        }
        private void PetFood_RowUpdated(object sender, RowObjectEventArgs e)
        {
            PetFoodRepo petfoodRepo = new PetFoodRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID).ToString());

            petfoodRepo.Update(id, (PetFood)bsPetFood.Current);
        }

        private void PetFood_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            PetFoodRepo petfoodRepo = new PetFoodRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID).ToString());

            petfoodRepo.Delete(id);
        }

        //==============================Transactions=================================================












        //===========================================Utility Functions================================
        public void setupCustomerRepo()
        {
            CustomersRepo customerRepo = new CustomersRepo();
            bsCustomers.DataSource = customerRepo.GetAll();
            grdCustomers.DataSource = bsCustomers;
        }

        public void setupEmployeesRepo()
        {   
            EmployeesRepo emplRepo = new EmployeesRepo();
            bsEmployees.DataSource = emplRepo.GetAll();
            grdEmployees.DataSource = bsEmployees;
        }

        public void setupPetsRepo()
        {
            PetRepo petRepo = new PetRepo();
            bsPets.DataSource = petRepo.GetAll();
            grdPet.DataSource = bsPets;
        }

        public void setupPetFoodsRepo()
        {
            PetFoodRepo petFRepo = new PetFoodRepo();
            bsPetFood.DataSource = petFRepo.GetAll();
            grdPetFood.DataSource = bsPetFood;
        }

       
    }
}


/*INSERT INTO[Transactions]( [TransID]
      ,[Date]
      ,[CustomerID]
      ,[EmployeeID]
      ,[PetID]
      ,[PetFoodID]
      ,[PetPrice]
      ,[PetFoodQty]
      ,[PetFoodPrice]
      ,[TotalPrice])
  VALUES('A7BCC72D-1647-44D9-8FA4-0DAA06E0D854', '2022-12-20 00:00:00.0000000', '2D9C43AC-6013-4F15-B5AB-F64EDE27A761', '70A61981-8A1F-49D1-8203-5EAE7F70C1C0', 'E7575254-9398-4E27-9C51-E1116F5BBF84', '085B1145-EF7E-49B0-8724-015748A93C20', '1300.00', '6.00', '10.00', '1350.00');
*/

