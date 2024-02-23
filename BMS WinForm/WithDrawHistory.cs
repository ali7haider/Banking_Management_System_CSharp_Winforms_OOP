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
    public partial class WithDrawHistory : Form
    {
        public WithDrawHistory()
        {
            InitializeComponent();
        }

        private void WithDrawHistory_Load(object sender, EventArgs e)
        {
            
            dataBind();
        }
        private void dataBind()
        {
            CustomerDL.WithDrawList.Clear();
            CustomerDL.readWithDrawHistory("withDrawHistory.txt");
            usersGV.DataSource = null;
            usersGV.DataSource = CustomerDL.WithDrawList.Select(c => new { c.WithDrawMoney, c.Date }).ToList();
            usersGV.Refresh();
        }
    }
}
