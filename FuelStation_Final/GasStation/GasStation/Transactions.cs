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
    public partial class Transactions_frm : Form
    {
        public Transactions_frm()
        {
            InitializeComponent();
        }
        private void Transactions_frm_Load(object sender, EventArgs e)
        {
            


        }



//===============================Transaction  Buttons=============================================
        private void btn_trans_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerCheck cardCheck = new CustomerCheck();
           
        }
        
       
        
       
//===============================Transaction Line Buttons=========================================
        private void btn_trl_Add_Click(object sender, EventArgs e)
        {
           
            
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
