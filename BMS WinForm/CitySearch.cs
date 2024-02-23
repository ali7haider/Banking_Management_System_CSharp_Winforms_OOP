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
    public partial class CitySearch : UserControl
    {
        public CitySearch()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            bool check = false;
            foreach (var A in AdminDL.CustomersList)
            {
                if (txtSearchCity.Text == A.City)
                {
                    check = true;
                    SearchResult S = new SearchResult(A);
                    S.ShowDialog();

                }
            }
            if (check == false)
            {
                MessageBox.Show("No User Found with Such City");
            }

        }
    }
}
