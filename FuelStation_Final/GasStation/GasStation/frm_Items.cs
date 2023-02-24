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
            grv_Items.DataSource = _itemList;









        }

//==============================Buttons & Events ================================
        private  async void btn_Item_save_Click(object sender, EventArgs e)
        {
            //TODO: SAVE for POST AND EDIT
        }

        private async void btn_Item_Load_Click(object sender, EventArgs e)
        {
            

        }

        private async void btn_Item_delete_Click(object sender, EventArgs e)
        {
            //TODO: DELETE BUTTON WITH  ASYNC
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //BACK TO FORM1
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //CLOSE BUT RETURN TO FORM 1
        }

        private void sqlDataAdapter1_RowUpdated(object sender, Microsoft.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }
    }
}
