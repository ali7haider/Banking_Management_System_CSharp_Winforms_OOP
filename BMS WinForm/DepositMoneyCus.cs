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
    public partial class DepositMoneyCus : UserControl
    {
        private string path = "depositHistory.txt";
        public DepositMoneyCus()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                double money = double.Parse(txtDepositMoney.Text);
                Admin A = AdminDL.Current;
                string date = dateDepositMoney.Text;
                A.TotalMoney = A.TotalMoney + money;
                Customer C = new Customer(AdminDL.Current.UserName ,money, date);
                CustomerDL.storeDepositHistory(path, C);
                CustomerDL.DepositList.Add(C);
                MessageBox.Show("Money Added Succesfully");
                clearFormData();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void clearFormData()
        {
            dateDepositMoney.Text = "";
            txtDepositMoney.Text = "";
        }

        private void btnViewDepositHistory_Click(object sender, EventArgs e)
        {
            DepositHistory D = new DepositHistory();
            D.ShowDialog();
        }
    }
}
