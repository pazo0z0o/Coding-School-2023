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
            grv_TransactionLine.AutoGenerateColumns = false;
            grv_Transactions.AutoGenerateColumns = false;
            SetControlProperties();

        }
        private  async Task SetControlProperties()
        {

        }


//===============================Transaction  Buttons=============================================
        private void btn_trans_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerCheck cardCheck = new CustomerCheck();
            cardCheck.ShowDialog();
           
        }
        
       
        
       
//===============================Transaction Line Buttons=========================================
        private void btn_trl_Add_Click(object sender, EventArgs e)
        {
            grv_TransactionLine.Rows.Add();
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1= new Form1();
            frm1.ShowDialog();
            this.Dispose();
        }
    }
}
