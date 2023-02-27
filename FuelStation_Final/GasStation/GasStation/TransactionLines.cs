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
        private TransactionLineListDTO _newLine = new();
        private TransactionListDTO _parentTransaction = new();

        //Constructors
        public frm_TransactionLines()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        public frm_TransactionLines(TransactionListDTO passedTransaction, List<TransactionLineListDTO> transactionLines)
        {
            _translineList = transactionLines;
            _parentTransaction = passedTransaction;
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
            _itemList = await _client.GetFromJsonAsync<List<ItemListDTO>>("item");

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
            //maybe a post before creating a new line?

            bsTransLine.AddNew();
            _newLine = bsTransLine.Current as TransactionLineListDTO;
            _newLine.TransactionId = _parentTransaction.ID;
            
            

        }


        private void bsTransLine_CurrentItemChanged(object sender, EventArgs e)
        {
            List<ItemListDTO> listItems = _itemList.Where(type => type.ItemType == ItemType.Fuel).ToList();
            if (_transHandler.ValidateFuelLines(_parentTransaction))
            {
                foreach (var item in listItems)
                {
                    if (_newLine.ItemID == item.ID)
                    {
                        MessageBox.Show("You cannot select an item of type fuel.", "Error");
                    }
                }


            }




            //==========================Auto-Fill Item Price=================================== 


            if (_newLine != null && _newLine.ItemID != 0)
            {
                var selectedItem = _itemList.FirstOrDefault(i => i.ID == _newLine.ItemID);
                if (selectedItem != null)
                {
                    _newLine.ItemPrice = selectedItem.Price;
                }
            }
            //=========================Auto-Fill Net Value====================================    
            if (_newLine != null && _newLine.ItemPrice != 0 && _newLine.Quantity > 0)
            { _newLine.NetValue = _newLine.ItemPrice * _newLine.Quantity; }

            //=============================Check for >20 AND fuel type =======================================

            if (_newLine.NetValue > 20 && _translineList.Any(x => listItems.Any(item => item.ID == x.ItemID)))
            {
                _newLine.DiscountPercent = 0.1M;
            }
            else _newLine.DiscountPercent = 0;

            _newLine.DiscountValue = _newLine.NetValue * _newLine.DiscountPercent;
            _newLine.TotalValue = _newLine.NetValue - _newLine.DiscountValue;

            //=============================End Gridview Edit=======================================   
            bsTransLine.EndEdit();
            grv_TransactionLine.DataSource = bsTransLine;

        }

        //END TRANSACTION BUTTON -- will decide what to send other than total value
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm transact = new Transactions_frm(_newLine.TotalValue);
            transact.ShowDialog();
            this.Dispose();
        }


        private async void btn_trl_delete_Click(object sender, EventArgs e)
        {
            TransactionLineListDTO transLineDelete = (TransactionLineListDTO)bsTransLine.Current;
            HttpResponseMessage response = null;
            response = await _client.DeleteAsync($"transaction/{transLineDelete.ID}");

            await SetControlProperties();
        }

        private void grv_TransactionLine_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void grv_TransactionLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
