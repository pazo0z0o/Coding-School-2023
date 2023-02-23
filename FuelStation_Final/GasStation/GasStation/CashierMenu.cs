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
    public partial class CashierMenu : Form
    {
        public CashierMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mng_Customer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_frm frm_Customer = new Customer_frm();
            frm_Customer.ShowDialog();
        }

        private void btn_mng_Transaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm frm_Transaction = new Transactions_frm();
            frm_Transaction.ShowDialog();
        }

        private void cash_Back_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
