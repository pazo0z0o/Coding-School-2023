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
    {   private CustomersRepo _customerRepo;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            _customerRepo = new CustomersRepo();
        }

        private void SetControlProperties()
        {   //Customer binding Source
            grvCustomers.AutoGenerateColumns = false;
            bsCustomers.DataSource =  
            grvCustomers.DataSource = bsCustomers;
        }


            private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
           //
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var newCustom = new Customers( );
            _customerRepo.Delete(newCustom.CustomerID);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            var newCustom = new Customers(TxtBox1.Text);

//stuck question
            
            _customerRepo.Add(newCustom);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            //grvCustomers.DataSource = null;
            grvCustomers.DataSource = _customerRepo.GetAll();
            grvCustomers.Update();
            grvCustomers.Refresh();
           // _customerRepo.Columns[index: 0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // _customerRepo.Columns[index: 2].Visible = false;
           // _customerRepo.Columns[index: 3].Visible = false;
            //TodoGV.Columns[index: 4].Visible = false;
        }
    }
}
