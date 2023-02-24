﻿using GasStation;
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
            CustomerListF customF = new CustomerListF();
            customF.ShowDialog();
            this.Dispose();
        }

        private void btn_mng_Transaction_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transactions_frm frm_Transaction = new Transactions_frm();
            frm_Transaction.ShowDialog();
            this.Dispose();
        }

        private void cash_Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void CashierMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
