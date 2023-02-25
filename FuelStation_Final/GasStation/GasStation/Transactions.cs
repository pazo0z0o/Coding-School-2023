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
        

        public Transactions_frm()
        {
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
            _transactionList = await _client.GetFromJsonAsync<List<TransactionListDTO>>("transaction");
            bsTransaction.DataSource= _transactionList;
            grv_Transactions.DataSource = bsTransaction; 
        }


//===============================Transaction  Button s=============================================
        private void btn_trans_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerCheck cardCheck = new CustomerCheck();
            cardCheck.ShowDialog();
           
        }




        //===============================Transaction Line Buttons=========================================



    }
}
