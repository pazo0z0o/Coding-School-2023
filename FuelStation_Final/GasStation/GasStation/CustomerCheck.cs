using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.ManagerOnlyDTOs;
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
        //public static string CurrentCustomerCard { get; set; }
        private readonly HttpClient _client;
        private List<CustomerListDTO> _customerList = new();
        private List<EmployeeListDTO> _employeeList = new();
        private readonly TransactionHandler  _thandler = new();
        private  CustomerListDTO _customerFound = new();
        private int _empIDHandler { get; set; }    

        public CustomerCheck()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        private async void CustomerCheck_Load(object sender, EventArgs e)
        {
            _customerList = await _client.GetFromJsonAsync<List<CustomerListDTO>>("customer");
            _employeeList = await _client.GetFromJsonAsync<List<EmployeeListDTO>>("employee");
     
            comboBox1.DataSource = _employeeList.ToList();
            comboBox1.ValueMember = "ID";
            comboBox1.DisplayMember = "Surname";
       
        }
    //===================================================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm frm_Transaction = new Transactions_frm(_customerFound, _empIDHandler  );
             frm_Transaction.ShowDialog();
            this.Dispose();
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerListF customF = new CustomerListF();
            customF.ShowDialog();
            this.Dispose();
            this.Close();
        }
   //===================================================================================================
        private async Task<bool> CheckCustomerCardExists(string textboxInput)
        {
            _customerList = await _client.GetFromJsonAsync<List<CustomerListDTO>>("customer");
            var card = _customerList.FirstOrDefault(c => c.CardNumber == textboxInput);
            if (card != null)
            {
                _customerFound= card;
                return true;
            }
            else
            {   
                return false;
            }
        }

    private async void btn_Check_Click(object sender, EventArgs e)
        {
            bool cardCheckResult = await CheckCustomerCardExists(textBox1.Text);
           if (cardCheckResult) 
            {
                textBox1.BackColor = Color.LimeGreen;
                comboBox1.Visible= true;
                btn_Success.Visible= true;
                label2.Visible = true;

            }
           else
            {
                textBox1.BackColor = Color.LightCoral;
                btn_CreateCustomer.Visible= true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             _empIDHandler = (int)comboBox1.SelectedValue;
        }
   //===================================================================================================
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
