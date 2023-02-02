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


namespace Session_16_PetShop
{
    public partial class Form2 : Form
    {   
        public Session_16.EF.Models.PetShop petShop = new Session_16.EF.Models.PetShop();
        public EngagePopulate ep = new EngagePopulate();

        private CustomersRepo _customerRepo; //= new CustomersRepo();
        private EmployeesRepo _employeeRepo = new EmployeesRepo();
        private PetRepo _petRepo = new PetRepo();
        private PetFoodRepo _petFoodRepo = new PetFoodRepo();
        private TransactionsRepo _transactionsRepo = new TransactionsRepo();

        public Form2()
        {   
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
               
                InitPetShop(ep);
                SetControlProperties();
        }

        private void SetControlProperties()
        {   
              CustomerRepo customerRepo = new CustomerRepo();
            
              bsCustomers.DataSource = _customerRepo.GetAll();                    
              grdCustomers.DataSource = bsCustomers;  
                

        }

        public Session_16.EF.Models.PetShop InitPetShop(EngagePopulate eps) { return petShop = ep.SetPopulation(); }

    

        
        private void gridView1_ValidateRow(object sender,ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());
            
            if (_customerRepo.GetById(id) is null) 
            {
                _customerRepo.Add((Customers)bsCustomers.Current);
                    
            }  
        }
        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
             GridView view = sender as GridView;
             Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());

            _customerRepo.Update(id, (Customers)bsCustomers.Current);
        }
        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colID).ToString());
            _customerRepo.Delete(id);
        }
        //==============================Employees====================================================
        
    
        
    
    
    
    
    
    
    
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