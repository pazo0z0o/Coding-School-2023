using Azure;
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
        public readonly HttpClient client;
        // public readonly string baseURI; 
        public string? endpoint;
        private List<CustomerListDTO> customerList = new();
        private readonly RandomGenerators _generator = new();

        public CustomerListF()
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
        private async void btn_Customer_Load_Click(object sender, EventArgs e)
        {
            bsCustomers.DataSource = null;
            await SetControlProperties();
        }

        private async void btn_Customer_save_Click(object sender, EventArgs e)
        {
            // OnSave();
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
            var response = await client.DeleteAsync($"customer/{customer.ID}");
            MessageBox.Show("Failed to add new data.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await SetControlProperties();
        }

        private async void btn_Customer_edit_Click(object sender, EventArgs e)
        {
            ((CustomerListDTO)(bsCustomers.Current)).CardNumber = await _generator.CardNumberGeneratorAsync();

            // SetControlProperties();
        }

      

        private async void grv_Customers_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            List<CustomerListDTO> data = (List < CustomerListDTO > )bsCustomers.DataSource;
            CustomerListDTO currentSelection = (CustomerListDTO)bsCustomers.Current;
            //Put operation
            if (currentSelection != null)
            {
                HttpResponseMessage response = await client.PutAsJsonAsync($"customer/{currentSelection.ID}", currentSelection);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Edit Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //Post operation
            else
            {
                CustomerCreateDTO newCustomer = new CustomerCreateDTO();
                newCustomer = (CustomerCreateDTO)grv_Customers.Rows[e.RowIndex].DataBoundItem;
                HttpResponseMessage response = await client.PostAsJsonAsync($"customer", newCustomer);


                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Failed to add new data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                }

            }







            //  
            //
            //
            //   if (customerOnTable == null) { return; }
            //    if (customerOnTable.CardNumber == null) return;
            //    if (customerOnTable.ID == 0)
            //    {
            //        CustomerCreateDTO customer = new CustomerCreateDTO
            //        {
            //            Name = customerOnTable.Name,
            //            Surname = customerOnTable.Surname,
            //            CardNumber = customerOnTable.CardNumber
            //        };
            //        HttpResponseMessage? response;
            //        response = await client.PostAsJsonAsync("customer", customer);
            //        response.EnsureSuccessStatusCode();
            //        await SetControlProperties();
            //    }
            //    else
            //    {
            //        CustomerEditDTO customerToEdit = new CustomerEditDTO
            //        {
            //             customerToEdit
            //             customerToEdit
            //             customerToEdit
            //        };
            //    }
        }





    }
}
