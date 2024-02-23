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
    public partial class ReceivedMoney : UserControl
    {
        public ReceivedMoney()
        {
            InitializeComponent();
        }

        private void usersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ReceivedMoney_Load(object sender, EventArgs e)
        {
            dataBind();
        }
        private void dataBind()
        {
            CustomerDL.ReceivedMoneyList.Clear();
            CustomerDL.readSendHistory("sendMoneyPath.txt");
            usersGV.DataSource = null;
            usersGV.DataSource = CustomerDL.ReceivedMoneyList.Select(c => new { c.AccountNumber2, c.AccountNumber,c.Purpose,c.Date,c.TransactMoney }).ToList();
            usersGV.Columns["AccountNumber2"].HeaderText = "My AccountNumber";
            usersGV.Columns["AccountNumber"].HeaderText = "From AccountNumber";
            usersGV.Columns["TransactMoney"].HeaderText = "Received Money";

            usersGV.Refresh();
        }
    }
}
