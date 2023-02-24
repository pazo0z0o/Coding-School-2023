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
    public partial class CustomerCheck : Form
    {
        private readonly HttpClient _client;
        private List<CustomerListDTO> _customerList = new();
        private readonly RandomGenerators _generator = new();

        public CustomerCheck()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm frm_Transaction = new Transactions_frm();
            frm_Transaction.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerListF customF = new CustomerListF();
            customF.ShowDialog();
            this.Dispose();
        }

        private void CustomerCheck_Load(object sender, EventArgs e)
        {

        }

        private async Task<bool> CheckCustomerCardExists(string textboxInput)
        {
            _customerList = await _client.GetFromJsonAsync<List<CustomerListDTO>>("customer");

            if (_customerList.FindAll(card =>card.CardNumber == textboxInput ).Count() != 0 ) 
            { return true; }
            return false;
        }

    private async void btn_Check_Click(object sender, EventArgs e)
        {
            bool cardCheckResult = await CheckCustomerCardExists(textBox1.Text);
           if (cardCheckResult) 
            {
                btn_Success.Visible= true;
           MessageBox.Show("Existing Customer Found!", "Customer Exists",MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
           else
            {
                btn_CreateCustomer.Visible= true;
                MessageBox.Show("Customer Not Found, Proceed to create a new account", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}
