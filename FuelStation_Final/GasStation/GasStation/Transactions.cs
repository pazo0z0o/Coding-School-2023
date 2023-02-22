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
    public partial class Transactions_frm : Form
    {
        public Transactions_frm()
        {
            InitializeComponent();
        }
        private void Transactions_frm_Load(object sender, EventArgs e)
        {

        }


       

        private void btn_trans_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
           // frm_Cursomer_Check CustomerValidation = new frm_Cursomer_Check();
            //CustomerValidation.ShowDialog();
        }
        //=============================================================================================================
        private void grv_Transactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
         private void grv_TransactionLine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
