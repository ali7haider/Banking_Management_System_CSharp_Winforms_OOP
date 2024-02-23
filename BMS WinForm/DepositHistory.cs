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

namespace BMS_WinForm
{
    public partial class DepositHistory : Form
    {
        public DepositHistory()
        {

            InitializeComponent();
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepositHistory_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        private void dataBind()
        {
            CustomerDL.DepositList.Clear();
            CustomerDL.readDepositHistory("depositHistory.txt");
            usersGV.DataSource = null;
            usersGV.DataSource = CustomerDL.DepositList.Select(c => new { c.DepositMoney, c.Date }).ToList();
            usersGV.Refresh();
        }
    }
}
