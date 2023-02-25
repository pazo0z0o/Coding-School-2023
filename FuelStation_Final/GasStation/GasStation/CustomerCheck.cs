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
        public static string CurrentCustomerCard { get; set; }
        private readonly HttpClient _client;
        private List<CustomerListDTO> _customerList = new();
        private readonly TransactionHandler  _thandler = new();

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
            bool ret = false;
            _customerList = await _client.GetFromJsonAsync<List<CustomerListDTO>>("customer");
            foreach(var card in _customerList) 
            {
                if (_customerList.Where(card => card.CardNumber == textboxInput).Count() > 0 ) 
                {
                   CurrentCustomerCard = textboxInput;
                   ret =  true; 
                
                }  
                else { CurrentCustomerCard = string.Empty; }
            }
            { return ret; } 
        }

    private async void btn_Check_Click(object sender, EventArgs e)
        {
            bool cardCheckResult = await CheckCustomerCardExists(textBox1.Text);
           if (cardCheckResult) 
            {
                textBox1.BackColor = Color.LimeGreen;
                btn_Success.Visible= true;
           MessageBox.Show("Existing Customer Found!", "Customer Exists",MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
           else
            {
                textBox1.BackColor = Color.LightCoral;
                btn_CreateCustomer.Visible= true;
                MessageBox.Show("Customer Not Found, Proceed to create a new account", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        { 
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.ShowDialog();
            this.Dispose();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerCheck newCheck = new CustomerCheck();
            textBox1.Clear();
            newCheck.ShowDialog();
            this.Dispose();
        }
    }
}
