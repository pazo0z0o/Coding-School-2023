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
    public partial class CustomerCheck : Form
    {
        public CustomerCheck()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm newTrans = new Transactions_frm();
            newTrans.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer_frm frm_Customer = new Customer_frm();
            frm_Customer.ShowDialog();
        }

        private void CustomerCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
