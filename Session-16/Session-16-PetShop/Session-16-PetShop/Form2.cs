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
                _customerRepo = new CustomersRepo();
                InitPetShop(ep);
                SetControlProperties();
        }

        private void SetControlProperties()
        {   //Customer binding Source
              grvCustomers.AutoGenerateColumns = false;
              BindingSource bsCustomers = new BindingSource();
              bsCustomers.DataSource = _customerRepo.GetAll();
              grvCustomers.DataSource = bsCustomers;
        
        }

public Session_16.EF.Models.PetShop InitPetShop(EngagePopulate eps) { return petShop = ep.SetPopulation(); }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var newCustom = new Customers( );
            _customerRepo.Delete(newCustom.CustomerID);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            var newCustom = new Customers();
          //  _customerRepo.Add(newCustom);
//stuck question
            
            
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //grvCustomers.DataSource = null;
            grvCustomers.DataSource = _customerRepo.GetAll();
            grvCustomers.Update();
            grvCustomers.Refresh();
           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var newCustom = new Customers();
            _customerRepo.Add(newCustom);
            bsCustomers.Add(_customerRepo);
        }
    }
}
