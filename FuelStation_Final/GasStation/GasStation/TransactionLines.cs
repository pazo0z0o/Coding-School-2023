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
    public partial class frm_TransactionLines : Form
    {
        private readonly HttpClient _client;
        private List<TransactionListDTO> _transactionList = new();
        private List<TransactionLineListDTO> _translineList = new();
        private List<ItemListDTO> _itemList = new();
        private List<CustomerListDTO> _customerList = new();
        private List<EmployeeListDTO> _employeeList = new();
        private readonly TransactionHandler _transHandler = new();
        public frm_TransactionLines()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        private void TransactionLines_Load(object sender, EventArgs e)
        {
            grv_TransactionLine.AutoGenerateColumns = false;
            SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            grv_TransactionLine.AutoGenerateColumns = false;
            _translineList = await _client.GetFromJsonAsync<List<TransactionLineListDTO>>("transactionline");   
            bsTransLine.DataSource= _translineList;
            grv_TransactionLine.DataSource = bsTransLine;
        }

        private async Task OnSave()
        { 
        //TODO: EDIT + Post functionalities

        
        
        }





        


    //========================== Transaction Lines Buttons ============================
        
        private void btn_trl_Add_Click(object sender, EventArgs e)
        {
            grv_TransactionLine.Rows.Add();
        }
        
        
        //END TRANSACTION BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm transact = new Transactions_frm();
            transact.ShowDialog();
            this.Dispose();
        }

        private async void btn_trl_load_Click(object sender, EventArgs e)
        {
            bsTransLine.DataSource= null;
            await SetControlProperties();
        }

        private async void btn_trl_save_Click(object sender, EventArgs e)
        {
            //Save for POST PUT purposes
            await OnSave();
            await SetControlProperties();
        }

        private void btn_trl_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
