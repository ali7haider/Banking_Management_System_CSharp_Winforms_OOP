using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS_WinForm
{
    public partial class SearchCustomer : UserControl
    {
        public SearchCustomer()
        {
            InitializeComponent();
        }

        private void cmbSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSearchBy.SelectedItem.ToString()=="Name")
            {
                userNameSearch1.Hide();
                citySearch1.Hide();
                nameSearch1.Show();
                nameSearch1.BringToFront();
            }
            else if(cmbSearchBy.SelectedItem.ToString()=="UserName")
            {
                nameSearch1.Hide();
                citySearch1.Hide();
                phoneNumberSearch1.Hide();
                accountNumberSearch1.Hide();
                userNameSearch1.Show();
                userNameSearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "City")
            {
                nameSearch1.Hide();
                userNameSearch1.Hide();
                accountNumberSearch1.Hide();
                citySearch1.Hide();
                citySearch1.Show();
                citySearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "PhoneNumber")
            {
                nameSearch1.Hide();
                userNameSearch1.Hide();
                citySearch1.Hide();
                accountNumberSearch1.Hide();
                phoneNumberSearch1.Show();
                phoneNumberSearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "AccountNumber")
            {
                nameSearch1.Hide();
                userNameSearch1.Hide();
                citySearch1.Hide();
                phoneNumberSearch1.Hide();
                accountNumberSearch1.Show();
                accountNumberSearch1.BringToFront();
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SearchCustomer_Load(object sender, EventArgs e)
        {
            nameSearch1.Hide();
            userNameSearch1.Hide();
            citySearch1.Hide();
            phoneNumberSearch1.Hide();
            accountNumberSearch1.Hide();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSearchBy_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedItem.ToString() == "Name")
            {
                userNameSearch1.Hide();
                citySearch1.Hide();
                nameSearch1.Show();
                nameSearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "UserName")
            {
                nameSearch1.Hide();
                citySearch1.Hide();
                phoneNumberSearch1.Hide();
                accountNumberSearch1.Hide();
                userNameSearch1.Show();
                userNameSearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "City")
            {
                nameSearch1.Hide();
                userNameSearch1.Hide();
                accountNumberSearch1.Hide();
                citySearch1.Hide();
                citySearch1.Show();
                citySearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "PhoneNumber")
            {
                nameSearch1.Hide();
                userNameSearch1.Hide();
                citySearch1.Hide();
                accountNumberSearch1.Hide();
                phoneNumberSearch1.Show();
                phoneNumberSearch1.BringToFront();
            }
            else if (cmbSearchBy.SelectedItem.ToString() == "AccountNumber")
            {
                nameSearch1.Hide();
                userNameSearch1.Hide();
                citySearch1.Hide();
                phoneNumberSearch1.Hide();
                accountNumberSearch1.Show();
                accountNumberSearch1.BringToFront();
            }
        }

        private void accountNumberSearch1_Load(object sender, EventArgs e)
        {

        }
    }
}
