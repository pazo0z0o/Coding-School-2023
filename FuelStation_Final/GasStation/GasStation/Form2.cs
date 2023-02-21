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
            this.Hide();
            Customer_frm frm_Customer = new Customer_frm();
            frm_Customer.ShowDialog();
        }


        private void btn_mng_Item_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Items frm_Items = new frm_Items();
            frm_Items.ShowDialog();
        }

        private void btn_mng_Transaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm frm_Transaction = new Transactions_frm();
            frm_Transaction.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 form1 = new Form1();
            form1.Show();
        }

        //accidental double clicks bellow here -- remember to clean up afterwards from the designer
          private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
