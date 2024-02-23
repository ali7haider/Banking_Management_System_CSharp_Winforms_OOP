using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_WinForm.DL;
using BMS_WinForm.BL;

namespace BMS_WinForm
{
    public partial class CustomerWindow : Form
    {
       
        public CustomerWindow()
        {
            
        }

        private void btnTransactMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnReceivedMoney_Click(object sender, EventArgs e)
        {

        }

        private void btnCusLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn F = new LogIn();
            F.Show();
        }

        private void CustomerWindow_Load(object sender, EventArgs e)
        {
            /*customerHome1.Hide();*/
        }

        private void btnCusHome_Click(object sender, EventArgs e)
        {
            /*customerHome1.Show();
            customerHome1.BringToFront();*/
        }

        private void tableLayoutPanel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
