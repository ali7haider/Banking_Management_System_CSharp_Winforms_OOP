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
    public partial class WithDrawMoneyCus : UserControl
    {
        private string path = "withDrawHistory.txt";
        public WithDrawMoneyCus()
        {
            InitializeComponent();
        }

        private void btnComfirm_Click(object sender, EventArgs e)
        {
            try
            {
                double money = double.Parse(txtWithDrawMoney.Text);
                Admin A = AdminDL.Current;
                string date = dateWithDrawMoney.Text;
                A.TotalMoney = A.TotalMoney + money;
                Customer C = new Customer(AdminDL.Current.UserName,date,money);
                CustomerDL.storeWithDrawHistory(path, C);
                CustomerDL.WithDrawList.Add(C);
                MessageBox.Show("Money Withdrawed Succesfully");
                clearFormData();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void clearFormData()
        {
            txtWithDrawMoney.Text = "";
            dateWithDrawMoney.Text = "";
        }

        private void btnWithDrawHistory_Click(object sender, EventArgs e)
        {
            WithDrawHistory H = new WithDrawHistory();
            H.ShowDialog();
        }
    }
}
