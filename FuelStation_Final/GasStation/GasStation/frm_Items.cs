using FuelStation.EF.Repositories;
using FuelStation.Model;
using FuelStation.Web.Shared.ManagerStaffSharedDTOs;
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
    public partial class frm_Items : Form
    {
        private readonly HttpClient _client;
        private List<ItemListDTO> _itemList = new();
        private readonly TransactionHandler _transHandler = new();

        public frm_Items()
        {
            _client = new HttpClient(new HttpClientHandler());
            _client.BaseAddress = new Uri("https://localhost:7086/");
            InitializeComponent();
        }
        private void frm_Items_Load(object sender, EventArgs e)
        {
            grv_Items.AutoGenerateColumns = false;
            SetControlProperties();
        }

        private async Task SetControlProperties()
        {
            grv_Items.AutoGenerateColumns = false;
            _itemList = await _client.GetFromJsonAsync<List<ItemListDTO>>("item");
            bsItems.DataSource = _itemList;
            grv_Items.DataSource = bsItems;
           
            DataGridViewComboBoxColumn col_ItemType = grv_Items.Columns["col_ItemType"] as DataGridViewComboBoxColumn;
            col_ItemType.DataSource = Enum.GetValues(typeof(ItemType));
           // col_ItemType.ValueMember = "ID";
            //col_ItemType.DisplayMember = "ItemType";
        }

        //==============================Buttons & Events ================================
        private async void btn_Item_save_Click(object sender, EventArgs e)
        {
            //TODO: SAVE for POST AND EDIT
            HttpResponseMessage response = null;
            ItemListDTO item = (ItemListDTO)bsItems.Current;
            if (item.ID == 0)
            {
                ItemCreateDTO itemCreate = new ItemCreateDTO
                {
                    Code = item.Code,
                    Description = item.Description,
                    ItemType = item.ItemType,
                    Price = item.Price,
                    Cost= item.Cost
                };
                response = await _client.PostAsJsonAsync("item", itemCreate);
            }
            else
            {
                ItemEditDTO itemEdit = new ItemEditDTO
                {
                    ID = item.ID,
                    Code = item.Code,
                    Description = item.Description,
                    ItemType = item.ItemType,
                    Price = item.Price,
                    Cost = item.Cost
                };
                response = await _client.PutAsJsonAsync("item", itemEdit);
            }
            if (response.IsSuccessStatusCode)
            { MessageBox.Show("Save successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            { MessageBox.Show("Save unsuccessful!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

            private async void btn_Item_Load_Click(object sender, EventArgs e)
        {
            bsItems.DataSource = null;
            SetControlProperties();
        }

        private async void btn_Item_delete_Click(object sender, EventArgs e)
        {
            //TODO: DELETE BUTTON WITH  ASYNC
            ItemListDTO items = (ItemListDTO)bsItems.Current;
            HttpResponseMessage response = null;
            response = await _client.DeleteAsync($"item/{items.ID}");
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //BACK TO FORM1
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Dispose();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //CLOSE BUT RETURN TO FORM 1
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Dispose();
        }
        //public async Task<bool> CodeChecker(ItemListDTO currentItem)
        //{
        //    currentItem = (ItemListDTO)bsItems.Current;
        //    _itemList = await _client.GetFromJsonAsync<List<ItemListDTO>>("item");
        //    foreach (var item in _itemList)
        //    {
        //        if (item.Code == currentItem.Code) return false;
        //    }
        //    return true;
        //}

    }
}
