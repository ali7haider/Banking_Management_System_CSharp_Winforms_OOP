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
    public partial class CustomerHome : UserControl
    {
        
        public CustomerHome()
        {
            
            InitializeComponent();
        }

        private void CustomerHome_Load(object sender, EventArgs e)
        {
            lblName.Text = AdminDL.Current.Name;
            lblUserName.Text = AdminDL.Current.UserName;
            lblPassword.Text = AdminDL.Current.Password;
            lblCity.Text = AdminDL.Current.City;
            lblPhoneNumber.Text = AdminDL.Current.PhoneNumber;
            lblAccountType.Text = AdminDL.Current.AccountType;
            lblAccountNumber.Text = AdminDL.Current.AccountNumber.ToString();
            lblIntialDeposit.Text = AdminDL.Current.IntialDeposit.ToString();
            lblTotalMoney.Text = AdminDL.Current.TotalMoney.ToString();
        }
    }
}
