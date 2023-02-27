using FuelStation.Win;
using System.Windows.Forms;

namespace GasStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void btn_Manager_Click(object sender, EventArgs e)
        {
            frm_manager managerForm = new frm_manager();
            managerForm.Show();
            this.Hide();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cashier_Click(object sender, EventArgs e)
        {
            CashierMenu frm_Cashier = new CashierMenu();
            frm_Cashier.ShowDialog();
            this.Hide();
           
        }

        private void btn_Staff_Click(object sender, EventArgs e)
        {
            frm_Items newItem = new frm_Items();
            newItem.ShowDialog();
            this.Hide();
            
        }
    }
}