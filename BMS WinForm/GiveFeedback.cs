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
    public partial class GiveFeedback : UserControl
    {
        private string path = "feedBacks.txt";

        public GiveFeedback()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer C = new Customer(AdminDL.Current.UserName, txtFeedBack.Text);
            CustomerDL.storeFeedBack(path, C);
            txtFeedBack.Text = "";
            MessageBox.Show("FeedBack Submitted");
        }
    }
}
