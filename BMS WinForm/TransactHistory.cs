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
    public partial class TransactHistory : Form
    {
        public TransactHistory()
        {
            InitializeComponent();
        }

        private void TransactHistory_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        private void dataBind()
        {
            CustomerDL.TransactList.Clear();
            CustomerDL.readTransactHistory("transactHistory.txt");
            usersGV.DataSource = null;
            usersGV.DataSource = CustomerDL.TransactList.Select(c => new { c.AccountNumber, c.Purpose,c.TransactMoney,c.Date }).ToList();
            usersGV.Refresh();
        }
    }
}
