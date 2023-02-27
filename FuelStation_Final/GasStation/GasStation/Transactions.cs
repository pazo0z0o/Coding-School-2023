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
using static System.Net.WebRequestMethods;

namespace FuelStation.Win
{
    public partial class Transactions_frm : Form
    {
        private readonly HttpClient _client;

        private List<TransactionListDTO> _transactionList = new();
        private List<TransactionLineListDTO> _translineList = new();
        private List<CustomerListDTO> _customerList = new();
        private List<EmployeeListDTO> _employeeList = new();
        
        private readonly CustomerListDTO _foundCustomer = new();
        private readonly int _employeeHandledTransation ;
        public TransactionListDTO newTrans = new TransactionListDTO() { Date = DateTime.Now };


        public Transactions_frm()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        public Transactions_frm(CustomerListDTO incomingCustomer, int currentEmployeeID)
        {
            _employeeHandledTransation = currentEmployeeID;
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
        private async Task SetControlProperties()
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
                col_EmployeeID.DataSource = _employeeList.ToList();
                col_EmployeeID.ValueMember = "ID";
                col_EmployeeID.DisplayMember = "Surname";

                DataGridViewComboBoxColumn col_CustomerID = grv_Transactions.Columns["col_CustomerID"] as DataGridViewComboBoxColumn;
                col_CustomerID.DataSource = _customerList.ToList();
                col_CustomerID.ValueMember = "ID";
                col_CustomerID.DisplayMember = "Surname";

                DataGridViewComboBoxColumn col_PaymentMethod = grv_Transactions.Columns["col_Payment"] as DataGridViewComboBoxColumn;
                col_PaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading data: {ex.Message}");
            }
        }
        //===============================Transaction  Button s=============================================
        private async void btn_trans_Add_Click(object sender, EventArgs e)
        {
            bsTransaction.AddNew();

            newTrans = bsTransaction.Current as TransactionListDTO;
            if (newTrans != null)
            {
                if (_foundCustomer != null)
                {
                    newTrans.CustomerId = _foundCustomer.ID;
                    newTrans.EmployeeId = _employeeHandledTransation;
                    newTrans.Date = DateTime.Now;
                    bsTransaction.EndEdit();
                    grv_Transactions.DataSource = bsTransaction;
                }
                else
                {
                    MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (newTrans.CustomerId != null)
                {
                    btn_procceed.Enabled = true;
                    btn_trans_Add.Enabled = false;
                }
            }
        }

        private async void btn_procceed_Click(object sender, EventArgs e)
        {
            await OnSave(newTrans);
            await SetControlProperties();
            
            var tmpTrans = bsTransaction.Current as TransactionListDTO;
            
            this.Hide();
            frm_TransactionLines tlines = new frm_TransactionLines(tmpTrans, tmpTrans.TransactionLines);
            tlines.ShowDialog();
        }

        private async Task OnSave(TransactionListDTO newTrans)
        {
            HttpResponseMessage response = null;
            if (newTrans.ID == 0)
            {
                TransactionListDTO transactionToSave = new TransactionListDTO()
                {   ID= newTrans.ID,
                    CustomerId = newTrans.CustomerId,
                    Date = newTrans.Date,
                    EmployeeId = newTrans.EmployeeId,
                    PaymentMethod = newTrans.PaymentMethod,
                    TotalValue = newTrans.TotalValue
                };
                response = await _client.PostAsJsonAsync("transaction", transactionToSave);
                //if (response.IsSuccessStatusCode)
                //{ MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                //else
                //{ MessageBox.Show("Save unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Form1 frm1_return = new Form1();
            frm1_return.ShowDialog();
            this.Dispose();
            this.Close();
        }
        private void grv_Transactions_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private async void btn_trans_delete_Click(object sender, EventArgs e)
        {
            TransactionListDTO transDEL = (TransactionListDTO)bsTransaction.Current;
            HttpResponseMessage response = null;
            response = await _client.DeleteAsync($"transaction/{transDEL.ID}");
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Delete Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delete unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            await SetControlProperties();


        }

        private async void btn_trans_Load_Click(object sender, EventArgs e)
        {
            bsTransaction.DataSource = null;
            SetControlProperties();
        }
    }







}

