using GasStation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.Win
{
    public partial class frm_manager : Form
    {
        public frm_manager()
        {
            InitializeComponent();
        }
        private void frm_manager_Load(object sender, EventArgs e)
        {

        }

        private void btn_mng_Customer_Click(object sender, EventArgs e)
        {
            CustomerListF customF = new CustomerListF();
            customF.ShowDialog();
            this.Hide();
        }
        private void btn_mng_Item_Click(object sender, EventArgs e)
        {
            frm_Items frm_Items = new frm_Items();
            frm_Items.ShowDialog();
            this.Close();
        }

        private void btn_mng_Transaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerCheck cardCheck = new CustomerCheck();
            cardCheck.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
          private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
