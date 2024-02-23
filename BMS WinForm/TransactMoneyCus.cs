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
    public partial class r : UserControl
    {
        private string sendMoneyPath = "sendMoneyPath.txt";
        private string path = "transactHistory.txt";
        public r()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewTransactHistory_Click(object sender, EventArgs e)
        {
            TransactHistory T = new TransactHistory();
            T.ShowDialog();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                double accountNumber = double.Parse(txtAccountNumber.Text);
                foreach (Admin A in AdminDL.CustomersList)
                {
                    if (accountNumber == A.AccountNumber)
                    {
                        check = true;
                        
                    }
                }
                if(check==false)
                {
                    throw new Exception("No Account Found with Such Account Number");
                }
                if (check == true)
                {
                    string purpose = cmbPurpose.Text;
                    double transactMoney = double.Parse(txtTransactMoney.Text);
                    string date = dateTransactMoney.Text;
                    Customer C = new Customer(AdminDL.Current.UserName, accountNumber, purpose, transactMoney, date);
                    Customer Cos = new Customer(accountNumber, AdminDL.Current.AccountNumber, purpose, transactMoney, date);
                    CustomerDL.TransactList.Add(C);
                    CustomerDL.storeTransactHistory(path, C);
                    CustomerDL.storeSendMoney(sendMoneyPath, Cos, accountNumber);
                    MessageBox.Show("Money Send Successfully");
                    
                    clearFormData();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void clearFormData()
        {
            txtAccountNumber.Text = "";
            txtTransactMoney.Text = "";
            cmbPurpose.Text = "";
            dateTransactMoney.Text = "";
        }
    }
}
