
namespace BMS_WinForm
{
    partial class AdminWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.iconminimizar = new System.Windows.Forms.PictureBox();
            this.iconrestaurar = new System.Windows.Forms.PictureBox();
            this.iconmaximizar = new System.Windows.Forms.PictureBox();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.btnTotalMoneyInBank = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnlogoInicio = new System.Windows.Forms.PictureBox();
            this.adminFeedback1 = new BMS_WinForm.AdminFeedback();
            this.totalMoneyInBank1 = new BMS_WinForm.TotalMoneyInBank();
            this.viewCustomer1 = new BMS_WinForm.ViewCustomer();
            this.searchCustomer1 = new BMS_WinForm.SearchCustomer();
            this.addUser1 = new BMS_WinForm.AddUser();
            this.adminHome1 = new BMS_WinForm.AdminHome();
            this.panelContenedor.SuspendLayout();
            this.BarraTitulo.SuspendLayout();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelContenedor.Controls.Add(this.adminFeedback1);
            this.panelContenedor.Controls.Add(this.totalMoneyInBank1);
            this.panelContenedor.Controls.Add(this.viewCustomer1);
            this.panelContenedor.Controls.Add(this.searchCustomer1);
            this.panelContenedor.Controls.Add(this.addUser1);
            this.panelContenedor.Controls.Add(this.adminHome1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(333, 55);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(885, 717);
            this.panelContenedor.TabIndex = 5;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BarraTitulo.Controls.Add(this.iconminimizar);
            this.BarraTitulo.Controls.Add(this.iconrestaurar);
            this.BarraTitulo.Controls.Add(this.iconmaximizar);
            this.BarraTitulo.Controls.Add(this.iconcerrar);
            this.BarraTitulo.Controls.Add(this.btnMenu);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(333, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(885, 55);
            this.BarraTitulo.TabIndex = 4;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown_1);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btnLogOut);
            this.MenuVertical.Controls.Add(this.btnFeedBack);
            this.MenuVertical.Controls.Add(this.btnTotalMoneyInBank);
            this.MenuVertical.Controls.Add(this.btnSearchCustomer);
            this.MenuVertical.Controls.Add(this.btnViewCustomer);
            this.MenuVertical.Controls.Add(this.btnAddUser);
            this.MenuVertical.Controls.Add(this.btnHome);
            this.MenuVertical.Controls.Add(this.btnlogoInicio);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(4);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(333, 772);
            this.MenuVertical.TabIndex = 3;
            // 
            // iconminimizar
            // 
            this.iconminimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconminimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconminimizar.Image = global::BMS_WinForm.Properties.Resources.icon_minimizar;
            this.iconminimizar.Location = new System.Drawing.Point(777, 6);
            this.iconminimizar.Margin = new System.Windows.Forms.Padding(4);
            this.iconminimizar.Name = "iconminimizar";
            this.iconminimizar.Size = new System.Drawing.Size(24, 22);
            this.iconminimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconminimizar.TabIndex = 4;
            this.iconminimizar.TabStop = false;
            this.iconminimizar.Click += new System.EventHandler(this.iconminimizar_Click);
            // 
            // iconrestaurar
            // 
            this.iconrestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconrestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconrestaurar.Image = global::BMS_WinForm.Properties.Resources.icon_maximizar;
            this.iconrestaurar.Location = new System.Drawing.Point(812, 6);
            this.iconrestaurar.Margin = new System.Windows.Forms.Padding(4);
            this.iconrestaurar.Name = "iconrestaurar";
            this.iconrestaurar.Size = new System.Drawing.Size(24, 22);
            this.iconrestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconrestaurar.TabIndex = 3;
            this.iconrestaurar.TabStop = false;
            this.iconrestaurar.Visible = false;
            this.iconrestaurar.Click += new System.EventHandler(this.iconrestaurar_Click);
            // 
            // iconmaximizar
            // 
            this.iconmaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconmaximizar.Location = new System.Drawing.Point(812, 6);
            this.iconmaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.iconmaximizar.Name = "iconmaximizar";
            this.iconmaximizar.Size = new System.Drawing.Size(24, 22);
            this.iconmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconmaximizar.TabIndex = 2;
            this.iconmaximizar.TabStop = false;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = global::BMS_WinForm.Properties.Resources.icon_cerrar2;
            this.iconcerrar.Location = new System.Drawing.Point(846, 6);
            this.iconcerrar.Margin = new System.Windows.Forms.Padding(4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(24, 22);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 1;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::BMS_WinForm.Properties.Resources.Mobile_Menu_Icon;
            this.btnMenu.Location = new System.Drawing.Point(11, 7);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 43);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click_1);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::BMS_WinForm.Properties.Resources.logout;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(5, 496);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(333, 49);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "             Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click_1);
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.FlatAppearance.BorderSize = 0;
            this.btnFeedBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedBack.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedBack.ForeColor = System.Drawing.Color.White;
            this.btnFeedBack.Image = global::BMS_WinForm.Properties.Resources.reportes;
            this.btnFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedBack.Location = new System.Drawing.Point(0, 439);
            this.btnFeedBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(333, 49);
            this.btnFeedBack.TabIndex = 6;
            this.btnFeedBack.Text = "              Feedbacks";
            this.btnFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedBack.UseVisualStyleBackColor = true;
            this.btnFeedBack.Click += new System.EventHandler(this.btnFeedBack_Click_1);
            // 
            // btnTotalMoneyInBank
            // 
            this.btnTotalMoneyInBank.FlatAppearance.BorderSize = 0;
            this.btnTotalMoneyInBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnTotalMoneyInBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalMoneyInBank.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalMoneyInBank.ForeColor = System.Drawing.Color.White;
            this.btnTotalMoneyInBank.Image = global::BMS_WinForm.Properties.Resources.pagos;
            this.btnTotalMoneyInBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalMoneyInBank.Location = new System.Drawing.Point(0, 382);
            this.btnTotalMoneyInBank.Margin = new System.Windows.Forms.Padding(4);
            this.btnTotalMoneyInBank.Name = "btnTotalMoneyInBank";
            this.btnTotalMoneyInBank.Size = new System.Drawing.Size(333, 49);
            this.btnTotalMoneyInBank.TabIndex = 5;
            this.btnTotalMoneyInBank.Text = "              Total Money";
            this.btnTotalMoneyInBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalMoneyInBank.UseVisualStyleBackColor = true;
            this.btnTotalMoneyInBank.Click += new System.EventHandler(this.btnTotalMoneyInBank_Click_1);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.FlatAppearance.BorderSize = 0;
            this.btnSearchCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Image = global::BMS_WinForm.Properties.Resources.venta;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(0, 325);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(333, 49);
            this.btnSearchCustomer.TabIndex = 4;
            this.btnSearchCustomer.Text = "              Search Customer";
            this.btnSearchCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click_1);
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewCustomer.FlatAppearance.BorderSize = 0;
            this.btnViewCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomer.Image = global::BMS_WinForm.Properties.Resources.clientes;
            this.btnViewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomer.Location = new System.Drawing.Point(0, 268);
            this.btnViewCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(333, 49);
            this.btnViewCustomer.TabIndex = 3;
            this.btnViewCustomer.Text = "              View Customers";
            this.btnViewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click_1);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Image = global::BMS_WinForm.Properties.Resources.empleados;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(0, 212);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(333, 49);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "              Add Account";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_2);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(176)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::BMS_WinForm.Properties.Resources.producto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 155);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(333, 49);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "              Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnlogoInicio
            // 
            this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogoInicio.Image = global::BMS_WinForm.Properties.Resources.logo1;
            this.btnlogoInicio.Location = new System.Drawing.Point(4, 15);
            this.btnlogoInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogoInicio.Name = "btnlogoInicio";
            this.btnlogoInicio.Size = new System.Drawing.Size(339, 94);
            this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnlogoInicio.TabIndex = 0;
            this.btnlogoInicio.TabStop = false;
            // 
            // adminFeedback1
            // 
            this.adminFeedback1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFeedback1.Location = new System.Drawing.Point(0, 0);
            this.adminFeedback1.Name = "adminFeedback1";
            this.adminFeedback1.Size = new System.Drawing.Size(885, 717);
            this.adminFeedback1.TabIndex = 5;
            // 
            // totalMoneyInBank1
            // 
            this.totalMoneyInBank1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalMoneyInBank1.Location = new System.Drawing.Point(0, 0);
            this.totalMoneyInBank1.Name = "totalMoneyInBank1";
            this.totalMoneyInBank1.Size = new System.Drawing.Size(885, 717);
            this.totalMoneyInBank1.TabIndex = 4;
            // 
            // viewCustomer1
            // 
            this.viewCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCustomer1.Location = new System.Drawing.Point(0, 0);
            this.viewCustomer1.Name = "viewCustomer1";
            this.viewCustomer1.Size = new System.Drawing.Size(885, 717);
            this.viewCustomer1.TabIndex = 3;
            // 
            // searchCustomer1
            // 
            this.searchCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCustomer1.Location = new System.Drawing.Point(0, 0);
            this.searchCustomer1.Name = "searchCustomer1";
            this.searchCustomer1.Size = new System.Drawing.Size(885, 717);
            this.searchCustomer1.TabIndex = 2;
            // 
            // addUser1
            // 
            this.addUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUser1.Location = new System.Drawing.Point(0, 0);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(885, 717);
            this.addUser1.TabIndex = 1;
            // 
            // adminHome1
            // 
            this.adminHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminHome1.Location = new System.Drawing.Point(0, 0);
            this.adminHome1.Name = "adminHome1";
            this.adminHome1.Size = new System.Drawing.Size(885, 717);
            this.adminHome1.TabIndex = 0;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1218, 772);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AdminWindow_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AdminWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AdminWindow_MouseUp_1);
            this.panelContenedor.ResumeLayout(false);
            this.BarraTitulo.ResumeLayout(false);
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconrestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogoInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.PictureBox iconminimizar;
        private System.Windows.Forms.PictureBox iconrestaurar;
        private System.Windows.Forms.PictureBox iconmaximizar;
        private System.Windows.Forms.PictureBox iconcerrar;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Button btnFeedBack;
        private System.Windows.Forms.Button btnTotalMoneyInBank;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.PictureBox btnlogoInicio;
        private System.Windows.Forms.Button btnLogOut;
        private AdminHome adminHome1;
        private AddUser addUser1;
        private SearchCustomer searchCustomer1;
        private ViewCustomer viewCustomer1;
        private TotalMoneyInBank totalMoneyInBank1;
        private AdminFeedback adminFeedback1;
    }
}