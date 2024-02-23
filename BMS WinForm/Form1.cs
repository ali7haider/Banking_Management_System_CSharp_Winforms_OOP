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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            AdminDL.CustomersList.Clear();
            MUserDL.UsersList.Clear();
            AdminDL.read_data("customers.txt");
            MUserDL.read_data("Users.txt");
            InitializeComponent();
           
        }

      
        private void clearFormData()
        {
            txtUserName.Text = "";
            txtPassword.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSignIn_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            MUser U = new MUser(userName, password);
            MUser User = MUserDL.checkuser(U);
            if (User != null)
            {
                if (MUserDL.isAdmin(User))
                {
                    AdminWindow A = new AdminWindow();
                    A.Show();
                    this.Hide();
                }
                else
                {
                    this.Hide();
                    AdminDL.setCurrent(User);                    
                   CustomerWindowPAge Cus = new CustomerWindowPAge(AdminDL.Current);
                    Cus.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
            clearFormData();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            
        }
    }
}
