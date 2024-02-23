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
    public partial class BalanceDetailsCus : UserControl
    {
        public BalanceDetailsCus()
        {
            InitializeComponent();
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtIntialBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void BalanceDetailsCus_Load(object sender, EventArgs e)
        {
            CustomerDL.readDepositHistory("depositHistory.txt");
            CustomerDL.readWithDrawHistory("withDrawHistory.txt");
            CustomerDL.readTransactHistory("transactHistory.txt");
            CustomerDL.readSendHistory("sendMoneyPath.txt");
            txtIntialBalance.Text = AdminDL.Current.IntialDeposit.ToString();
         /*   txtDepositDetails.Text = CustomerDL.calculateDepositMoney().ToString();
            txtWithDrawMoneyDetails.Text = CustomerDL.calculateWithDrawMoney().ToString();
            txtTransactDetails.Text = CustomerDL.calculateTransactMoney().ToString();
            txtReceivedDetails.Text = CustomerDL.calculateReceivedMoney().ToString();
            txtAvailableDetails.Text = AdminDL.Current.TotalMoney.ToString();*/
            btnRefresh_Click(sender, e);
        }

        private void txtDepositDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWithDrawMoneyDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTransactDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReceivedDetails_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            double depoist = CustomerDL.calculateDepositMoney();
            txtDepositDetails.Text = depoist.ToString();
            double withdraw = CustomerDL.calculateWithDrawMoney();
            txtWithDrawMoneyDetails.Text = withdraw.ToString();
            double transact = CustomerDL.calculateTransactMoney();
            txtTransactDetails.Text = transact.ToString();
            double receive = CustomerDL.calculateReceivedMoney();
            txtReceivedDetails.Text = receive.ToString();
            double total = CustomerDL.totalMoney(depoist,withdraw, transact, receive);
            txtAvailableDetails.Text = total.ToString();
        }
    }
}
