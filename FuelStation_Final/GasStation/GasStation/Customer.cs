using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using GasStation;
using FuelStation.Model;
using Newtonsoft.Json;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using Azure;

namespace FuelStation.Win
{
    public partial class Customer_frm : Form
    {
        public readonly HttpClient client;
        // public readonly string baseURI; 
        public string endpoint;
        public Customer_frm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7086/");
            SetControlProperties();
        }

        private void grv_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void Customer_frm_Load(object sender, EventArgs e)
        {
            
            grv_Customers.AutoGenerateColumns = false;
            SetControlProperties();



        }
     //========================= METHODS =====================================
      
    
        private async Task SetControlProperties()
        {
            var customer = await CustomerGetAll();
            if( customer !=null)
            {
                bsCustomers.DataSource = customer;
                grv_Customers.DataSource = bsCustomers;
            }

        }
       
        private async Task<List<CustomerListDTO>> CustomerGetAll()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("customer");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<CustomerListDTO>>(content);
                }
                else
                {
                    throw new Exception($"Failed to retrieve customer list. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while retrieving the customer list: {ex.Message}");
                return null;
            }
        }
        //=========================== BUTTON EVENTS ===================================
        private void btn_Customer_Load_Click(object sender, EventArgs e)
        {
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
    }
}
