using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_WinForm.BL;
using BMS_WinForm.DL;

namespace BMS_WinForm
{
    public partial class TotalMoneyInBank : UserControl
    {

       

        public TotalMoneyInBank()
        {
            InitializeComponent();
            
            
            
        }

        private void txtTotalMoneyInBank_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TotalMoneyInBank_Load(object sender, EventArgs e)
        {

            txtTotalMoneyinBank.Text = AdminDL.calculate().ToString();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTotalMoneyinBank_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
