using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using GasStation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class Customer : Form
    {
        public readonly HttpClient client;
        // public readonly string baseURI; 
        public string endpoint;
        private List<CustomerListDTO> customerList = new();
        public Customer()
        {
            client = new HttpClient(new HttpClientHandler());
            client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();

        }

        private void CustomerListF_Load(object sender, EventArgs e)
        {
            grv_Customers.AutoGenerateColumns = false;
            SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            customerList = await client.GetFromJsonAsync<List<CustomerListDTO>>("customer");
            grv_Customers.AutoGenerateColumns = false;
            bsCustomers.DataSource = customerList;
            grv_Customers.DataSource = bsCustomers;


        }


        private async Task OnSave()
        {




        }

        //=========================== BUTTON EVENTS ===================================
        private void btn_Customer_Load_Click(object sender, EventArgs e)
        {
            bsCustomers.DataSource = null;
            SetControlProperties();
        }

        private void btn_Customer_save_Click(object sender, EventArgs e)
        {
            OnSave();
            SetControlProperties();
        }

        private void btn_Customer_Add_Click(object sender, EventArgs e)
        {
            bsCustomers.Add(new CustomerListDTO());
        }

        private void cash_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private async void btn_Customer_delete_Click(object sender, EventArgs e)
        {
            //bsCustomers.Current as CustomerListDTO customer;
            CustomerListDTO customer = (CustomerListDTO)bsCustomers.Current;
            var response = await client.DeleteAsync($"customer/{customer.ID}");
            SetControlProperties();
        }


























    }
}
