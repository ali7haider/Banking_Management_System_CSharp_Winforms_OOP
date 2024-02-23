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

namespace BMS_WinForm
{
    public partial class AdminFeedback : UserControl
    {
        public AdminFeedback()
        {
            InitializeComponent();
        }

        private void AdminFeedback_Load(object sender, EventArgs e)
        {
           
            dataBind();
        }
        private void dataBind()
        {
            CustomerDL.FeedBackList.Clear();
            CustomerDL.readFeedBacks("feedBacks.txt");
            usersGV.DataSource = null;
            usersGV.DataSource = CustomerDL.FeedBackList.Select(c => new { c.UserName, c.FeedBack}).ToList();
            usersGV.Columns["UserName"].HeaderText = "From UserName";
            usersGV.Refresh();
        }
    }
}
