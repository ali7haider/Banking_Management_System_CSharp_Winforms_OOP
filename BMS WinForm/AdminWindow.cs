using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS_WinForm.BL;
using BMS_WinForm.DL;

namespace BMS_WinForm
{
    public partial class AdminWindow : Form
    {

        private bool isDragging = false;
        private Point lastCursorPosition;
        public AdminWindow()
        {

            InitializeComponent();

        }


        private void btnAddNewAccount_Click(object sender, EventArgs e)
        {

            AddUser A = new AddUser();
            A.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private Form currentForm = null; // Field to keep track of the currently displayed form

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


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            addUser1.Hide();
            totalMoneyInBank1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            adminFeedback1.Hide();
            adminHome1.Show();
            adminHome1.BringToFront();
        }

        private void btnAddUser_Click_2(object sender, EventArgs e)
        {
            adminHome1.Hide();
            totalMoneyInBank1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            adminFeedback1.Hide();
            addUser1.Show();
            addUser1.BringToFront();
        }

        private void btnViewCustomer_Click_1(object sender, EventArgs e)
        {
            adminHome1.Hide();
            addUser1.Hide();
            searchCustomer1.Hide();
            viewCustomer1.Show();
            viewCustomer1.BringToFront();
            totalMoneyInBank1.Hide();
            adminFeedback1.Hide();
        }

        private void btnSearchCustomer_Click_1(object sender, EventArgs e)
        {
            adminHome1.Hide();
            addUser1.Hide();
            viewCustomer1.Hide();
            adminFeedback1.Hide();
            totalMoneyInBank1.Hide();
            searchCustomer1.Show();
            searchCustomer1.BringToFront();
        }

        private void btnTotalMoneyInBank_Click_1(object sender, EventArgs e)
        {
            adminHome1.Hide();
            addUser1.Hide();
            viewCustomer1.Hide();
            adminFeedback1.Hide();
            searchCustomer1.Hide();
            totalMoneyInBank1.Show();
            totalMoneyInBank1.BringToFront();
        }

        private void btnFeedBack_Click_1(object sender, EventArgs e)
        {
            addUser1.Hide();
            totalMoneyInBank1.Hide();
            viewCustomer1.Hide();
            searchCustomer1.Hide();
            adminHome1.Hide();
            adminFeedback1.Show();
            adminFeedback1.BringToFront();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            LogIn F = new LogIn();
            F.Show();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }
        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void btnMenu_Click_1(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 50;
            }
            else
            {
                MenuVertical.Width = 250;
            }
        }

        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void AdminWindow_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastCursorPosition.X;
                int deltaY = e.Location.Y - lastCursorPosition.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);

                lastCursorPosition = e.Location;
            }
        }

        private void AdminWindow_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastCursorPosition = e.Location;
            }
        }

        private void AdminWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastCursorPosition.X;
                int deltaY = e.Location.Y - lastCursorPosition.Y;

                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);

                lastCursorPosition = e.Location;
            }
        }
    }
    
}
