using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Web.Shared.Services_Logic;
using GasStation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class CustomerListF : Form
    {
        private readonly HttpClient _client;
        private List<CustomerListDTO> _customerList = new();
        private readonly RandomGenerators _generator = new();

        public CustomerListF()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }

        private void CustomerListF_Load(object sender, EventArgs e)
        {
            grv_Customers.AutoGenerateColumns = false;
            SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            grv_Customers.AutoGenerateColumns = false;
            _customerList = await _client.GetFromJsonAsync<List<CustomerListDTO>>("customer");
            bsCustomers.DataSource = _customerList;
            grv_Customers.DataSource = bsCustomers;
        }

        private async Task OnSave()
        {
            CustomerListDTO cutomer = (CustomerListDTO)bsCustomers.Current;
            HttpResponseMessage response = null;
            if (cutomer.ID == 0)
            {
                CustomerCreateDTO customerCreate = new CustomerCreateDTO
                {
                    Name = cutomer.Name,
                    Surname = cutomer.Surname,
                    CardNumber = cutomer.CardNumber
                };
                response = await _client.PostAsJsonAsync("customer", customerCreate);
            }
            else
            {
               // CustomerListDTO originalCustomer = _customerRepo.GetById(customer.ID);
                CustomerEditDTO customerEdit = new CustomerEditDTO
                {
                    ID = cutomer.ID,
                    Name = cutomer.Name,
                    Surname = cutomer.Surname,
                    CardNumber = cutomer.CardNumber

                };
                response = await _client.PutAsJsonAsync("customer", customerEdit);
            }
            if (response.IsSuccessStatusCode) 
            {MessageBox.Show("Save successful!","Success",MessageBoxButtons.OK,MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Save unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }


        }
        //=========================== BUTTON EVENTS ===================================
        private async void btn_Customer_Load_Click(object sender, EventArgs e)
        {
            bsCustomers.DataSource = null;
            await SetControlProperties();
        }

        private async void btn_Customer_save_Click(object sender, EventArgs e)
        {
            await OnSave();
            await SetControlProperties();
        }

        private void btn_Customer_Add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cash_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private async void btn_Customer_delete_Click(object sender, EventArgs e)
        {
            CustomerListDTO customer = (CustomerListDTO)bsCustomers.Current;
            var response = await _client.DeleteAsync($"customer/{customer.ID}");
            MessageBox.Show("Failed to add new data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await SetControlProperties();
        }

        private async void btn_Customer_edit_Click(object sender, EventArgs e)
        {
            ((CustomerListDTO)(bsCustomers.Current)).CardNumber = await _generator.CardNumberGeneratorAsync();
        }










    }
}
