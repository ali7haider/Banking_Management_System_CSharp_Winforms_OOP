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
   
    public partial class EditCustomer : Form
    {
        private Admin previous;
        public EditCustomer(Admin previous)
        {
            InitializeComponent();
            this.previous = previous;
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            txtName.Text = previous.Name;
            txtUserName.Text = previous.UserName;
            txtPassword.Text = previous.Password;
            cmbAccountType.Text = previous.AccountType;
            cmbCity.Text = previous.City;
            txtPhoneNumber.Text = previous.PhoneNumber;
            txtAccountNumber.Text = previous.AccountNumber.ToString();
            txtTotalMoney.Text = previous.TotalMoney.ToString();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            
            try { 
                double accountNumber = double.Parse(txtAccountNumber.Text);
                if (accountNumber < 100000 || accountNumber > 999999)
                {
                    throw new Exception("Account Number Should be of 6 Character");
                }
                 double totalMoney = double.Parse(txtTotalMoney.Text);
                Admin update = new Admin(txtName.Text, txtUserName.Text, txtPassword.Text, cmbAccountType.Text,cmbCity.Text, txtPhoneNumber.Text, accountNumber, previous.IntialDeposit, totalMoney);
                AdminDL.editCustomerData(previous, update);
                MUserDL.editCustomerData(previous.UserName, previous.Password,txtUserName.Text, txtPassword.Text);
                MUserDL.storeAllIds("Users.txt");
                this.Close();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
