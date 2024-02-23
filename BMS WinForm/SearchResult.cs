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
    public partial class SearchResult : Form
    {
        private Admin result;
        public SearchResult(Admin result)
        {
            InitializeComponent();
            this.result = result;
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {
            lblName.Text = result.Name;
            lblUserName.Text = result.UserName;
            lblPassword.Text = result.Password;
            lblCity.Text = result.City;
            lblPhoneNumber.Text = result.PhoneNumber;
            lblAccountType.Text = result.AccountType;
            lblAccountNumber.Text = result.AccountNumber.ToString();
            lblIntialDeposit.Text = result.IntialDeposit.ToString();
            lblTotalMoney.Text = result.TotalMoney.ToString();
        }
    }
}
