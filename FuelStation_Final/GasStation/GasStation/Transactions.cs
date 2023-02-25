using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
using FuelStation.Web.Shared.ManagerOnlyDTOs;
using FuelStation.Web.Shared.ItemDTOs;
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
using FuelStation.Model.Enums;
using FuelStation.Web.Client.Pages.Customer;

namespace FuelStation.Win
{
    public partial class Transactions_frm : Form
    {
        private readonly HttpClient _client;

        private List<TransactionListDTO> _transactionList = new();
        private List<TransactionLineListDTO> _translineList = new();
        private List<ItemListDTO> _itemList = new();
        private List<CustomerListDTO> _customerList = new();
        private List<EmployeeListDTO> _employeeList = new();
        private readonly TransactionHandler _transHandler = new();
        private readonly CustomerListDTO _foundCustomer = new();
        public Transaction newTrans = new();

        public Transactions_frm()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        public Transactions_frm(CustomerListDTO incomingCustomer)
        {
            _foundCustomer = incomingCustomer;
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        private void Transactions_frm_Load(object sender, EventArgs e)
        {
           
            grv_Transactions.AutoGenerateColumns = false;
            SetControlProperties();

        }
        private  async Task SetControlProperties()
        {
            grv_Transactions.AutoGenerateColumns = false;
            try
            {
                _customerList = await _client.GetFromJsonAsync<List<CustomerListDTO>>("customer");
                _employeeList = await _client.GetFromJsonAsync<List<EmployeeListDTO>>("employee");
                _transactionList = await _client.GetFromJsonAsync<List<TransactionListDTO>>("transaction");

                bsTransaction.DataSource = _transactionList;
                grv_Transactions.DataSource = bsTransaction;

                DataGridViewComboBoxColumn col_EmployeeID = grv_Transactions.Columns["col_EmployeeID"] as DataGridViewComboBoxColumn;
                col_EmployeeID.DataSource = _employeeList;
                col_EmployeeID.ValueMember = "EmployeeId";
                col_EmployeeID.DisplayMember = "Surname";

                DataGridViewComboBoxColumn col_PaymentMethod = grv_Transactions.Columns["col_Payment"] as DataGridViewComboBoxColumn;
                col_PaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            }
            catch (Exception ex)
            {
                // handle any exceptions thrown by the async methods
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }

        }


//===============================Transaction  Button s=============================================
        private async void btn_trans_Add_Click(object sender, EventArgs e)
        {
            
           int currentTransCustomer = _customerList.Where(customer => customer.CardNumber == CustomerCheck.CurrentCustomerCard).Select(Customer => Customer.ID).FirstOrDefault();
            
           // bsTransaction.AddNew();
            
            grv_Transactions.Rows.Add();            
            int rowIndex = grv_Transactions.Rows.Count - 1;            
            DataGridViewRow newRow = grv_Transactions.Rows[rowIndex];
            newRow.Cells["col_CustomerID"].Value =  currentTransCustomer;
            newRow.Cells["col_Date"].Value = DateTime.Now;
            if (newRow.Cells["col_CustomerID"].Value != null)
            {
                btn_procceed.Enabled = true;
            }



        }

       

        private void btn_procceed_Click(object sender, EventArgs e)
        {   
            this.Hide();
            frm_TransactionLines tlines = new frm_TransactionLines();
            tlines.ShowDialog();
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {   
            Form1 frm1_return = new Form1();
            frm1_return.ShowDialog();
            this.Dispose();
            this.Close();
        }







        //===============================Transaction Line Buttons=========================================



    }
}
