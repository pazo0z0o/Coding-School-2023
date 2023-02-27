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
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace FuelStation.Win
{
    public partial class frm_TransactionLines : Form
    {
        private readonly HttpClient _client;
       // private List<TransactionListDTO> _transactionList = new();
        private List<TransactionLineListDTO> _translineList = new();
        private List<ItemListDTO> _itemList = new();
        //private List<CustomerListDTO> _customerList = new();
        //private List<EmployeeListDTO> _employeeList = new();
        private readonly TransactionHandler _transHandler = new();
        private TransactionLine _newLine = new();


        //Constructors
        public frm_TransactionLines()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        public frm_TransactionLines(int newTransactionID, List<TransactionLineListDTO> transactionLines)
        {
            _translineList = transactionLines;
            _newLine.TransactionID = newTransactionID;
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
            bsTransLine.DataSource = _translineList;
            grv_TransactionLine.DataSource = bsTransLine;

            DataGridViewComboBoxColumn col_ItemID = grv_TransactionLine.Columns["col_ItemID"] as DataGridViewComboBoxColumn;
            col_ItemID.DataSource = _itemList.ToList();
            col_ItemID.ValueMember = "ID";
            col_ItemID.DisplayMember = "Description";
        }

        private async Task OnSave(TransactionLine newLine)
        {
            HttpResponseMessage response = null;



        }

    //========================== Transaction Lines Buttons ============================
        
        private void btn_trl_Add_Click(object sender, EventArgs e)
        {
            bsTransLine.AddNew();
            _newLine = bsTransLine.Current as TransactionLine;
            
            if( _newLine.TransactionID != null ) 
            { 
                //logic  CHECK APO CONTROLLER K AN OXI, IMPLEMENT STO ONSAVE    
                //_newLine.NetValue
                

                bsTransLine.EndEdit();
                grv_TransactionLine.DataSource = bsTransLine;

            }
        }
        //END TRANSACTION BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm transact = new Transactions_frm();
            transact.ShowDialog();
            this.Dispose();
        }


        private async void btn_trl_delete_Click(object sender, EventArgs e)
        {
            TransactionLineListDTO transLineDelete = (TransactionLineListDTO)bsTransLine.Current;
            HttpResponseMessage response = null;
            response = await _client.DeleteAsync($"transaction/{transLineDelete.ID}");
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

       
    }
}
