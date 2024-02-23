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
    public partial class CustomerWindowPAge : Form
    {
        private Admin A;
        public CustomerWindowPAge(Admin A)
        {
            this.A = A;
            InitializeComponent();
        }

        private void CusForm_Load(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            customerHome1.Hide();
            giveFeedback1.Hide();
        }

       

        private void btnMyAccountDetails_Click(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            homeScreenOf_Cus1.Hide();
            customerHome1.Show();
            customerHome1.BringToFront();
        }

        private void btnCusHome_Click(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            giveFeedback1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Show();
            homeScreenOf_Cus1.BringToFront();
        }

        private void btnGiveFeedBack_Click(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Hide();
            giveFeedback1.Show();
            giveFeedback1.BringToFront();
        }

        private void btnDepositMoney_Click_1(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            giveFeedback1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Hide();
            depositMoneyCus1.Show();
            depositMoneyCus1.BringToFront();
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            giveFeedback1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Hide();
            withDrawMoneyCus1.Show();
            withDrawMoneyCus1.BringToFront();
        }

        private void btnTransactMoney_Click(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            balanceDetailsCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            giveFeedback1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Hide();
            transactMoneyCus1.Show();
            transactMoneyCus1.BringToFront();
        }

        private void btnBalanceDetails_Click(object sender, EventArgs e)
        {
            receivedMoney1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            giveFeedback1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Hide();
            balanceDetailsCus1.Show();
            balanceDetailsCus1.BringToFront();
        }

        private void btnCusLogOut_Click(object sender, EventArgs e)
        {
            AdminDL.storeAllCustomers("customers.txt");
            this.Hide();
            LogIn F = new LogIn();
            F.Show();
        }

        private void btnReceivedMoney_Click(object sender, EventArgs e)
        {

            balanceDetailsCus1.Hide();
            transactMoneyCus1.Hide();
            withDrawMoneyCus1.Hide();
            depositMoneyCus1.Hide();
            giveFeedback1.Hide();
            customerHome1.Hide();
            homeScreenOf_Cus1.Hide();
            receivedMoney1.Show();
            receivedMoney1.BringToFront();
        }
    }
}
