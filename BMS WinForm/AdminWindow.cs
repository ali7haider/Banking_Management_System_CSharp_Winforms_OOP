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
    public partial class AdminWindow : Form
    {
        

        public AdminWindow()
        {
           
            InitializeComponent();
           
        }

        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {
           
            AddUser A = new AddUser();
            A.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {

            adminHome1.Show();
            adminHome1.BringToFront();
            addUser1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            totalMoneyInBank1.Hide();
            adminFeedback1.Hide();
           
        }
        private void BtnAddUser_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            adminHome1.Hide();
            addUser1.Hide();
            searchCustomer1.Hide();
            viewCustomer1.Show();
            viewCustomer1.BringToFront();
            totalMoneyInBank1.Hide();
            adminFeedback1.Hide();

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewCustomer1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            adminHome1.Hide();
            addUser1.Hide();
            viewCustomer1.Hide();
            adminFeedback1.Hide();
            totalMoneyInBank1.Hide();
            searchCustomer1.Show();
            searchCustomer1.BringToFront();
        }

        private void btnTotalMoneyInBank_Click(object sender, EventArgs e)
        {
            adminHome1.Hide();
            addUser1.Hide();
            viewCustomer1.Hide();
            adminFeedback1.Hide();
            searchCustomer1.Hide();
            totalMoneyInBank1.Show();
            totalMoneyInBank1.BringToFront();
        }

        
        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            adminHome1.Hide();
            totalMoneyInBank1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            adminFeedback1.Hide();
            addUser1.Show();
            addUser1.BringToFront();
        }

        private void btnFeedBack_Click(object sender, EventArgs e)
        {
            addUser1.Hide();
            totalMoneyInBank1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            adminHome1.Hide();
            adminFeedback1.Show();
            adminFeedback1.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addUser1.Hide();
            totalMoneyInBank1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            adminFeedback1.Hide();
            adminHome1.Show();
            adminHome1.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogIn F = new LogIn();
            F.Show();
        }
    }
}
