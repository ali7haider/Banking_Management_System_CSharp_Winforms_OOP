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
    public partial class NameSearch : UserControl
    {
        public NameSearch()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var A in AdminDL.CustomersList)
            {
                if (txtSearchName.Text == A.Name)
                {
                    check = true;
                    SearchResult S = new SearchResult(A);
                    S.ShowDialog();

                }
            }
            if (check == false)
            {
                MessageBox.Show("No User Found with Such UserName");
            }

        }
    }
}
