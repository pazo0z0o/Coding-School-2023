using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using GasStation;

namespace FuelStation.Win
{
    public partial class Customer_frm : Form
    {
        public Customer_frm()
        {
            InitializeComponent();
        }

        private void grv_Items_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_frm_Load(object sender, EventArgs e)
        {

        }

        private void cash_Back_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }

       
    }
}
