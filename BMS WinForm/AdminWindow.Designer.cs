
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnAddUser = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnFeedBack = new System.Windows.Forms.Button();
            this.btnTotalMoneyInBank = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnHome = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminFeedback1 = new BMS_WinForm.AdminFeedback();
            this.adminHome1 = new BMS_WinForm.AdminHome();
            this.totalMoneyInBank1 = new BMS_WinForm.TotalMoneyInBank();
            this.searchCustomer1 = new BMS_WinForm.SearchCustomer();
            this.viewCustomer1 = new BMS_WinForm.ViewCustomer();
            this.addUser1 = new BMS_WinForm.AddUser();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = global::BMS_WinForm.Properties.Resources.white___Copy;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.77821F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.22179F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.07053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.92947F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 794);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::BMS_WinForm.Properties.Resources.bluebackground;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.tableLayoutPanel2.Controls.Add(this.BtnAddUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnLogOut, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnFeedBack, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnTotalMoneyInBank, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnSearchCustomer, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 210);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(258, 581);
            this.tableLayoutPanel2.TabIndex = 0;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // BtnAddUser
            // 
            this.BtnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUser.ForeColor = System.Drawing.Color.White;
            this.BtnAddUser.Image = global::BMS_WinForm.Properties.Resources.icons8_add_user_male_40__1_;
            this.BtnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddUser.Location = new System.Drawing.Point(3, 73);
            this.BtnAddUser.Name = "BtnAddUser";
            this.BtnAddUser.Size = new System.Drawing.Size(252, 64);
            this.BtnAddUser.TabIndex = 16;
            this.BtnAddUser.Text = "Add Account";
            this.BtnAddUser.UseVisualStyleBackColor = false;
            this.BtnAddUser.Click += new System.EventHandler(this.BtnAddUser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = global::BMS_WinForm.Properties.Resources.icons8_logout_40;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 423);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(252, 64);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFeedBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedBack.ForeColor = System.Drawing.Color.White;
            this.btnFeedBack.Image = global::BMS_WinForm.Properties.Resources.icons8_feedback_40;
            this.btnFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedBack.Location = new System.Drawing.Point(3, 353);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Size = new System.Drawing.Size(252, 64);
            this.btnFeedBack.TabIndex = 11;
            this.btnFeedBack.Text = "FeedBacks";
            this.btnFeedBack.UseVisualStyleBackColor = false;
            this.btnFeedBack.Click += new System.EventHandler(this.btnFeedBack_Click);
            // 
            // btnTotalMoneyInBank
            // 
            this.btnTotalMoneyInBank.BackColor = System.Drawing.Color.Transparent;
            this.btnTotalMoneyInBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTotalMoneyInBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTotalMoneyInBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalMoneyInBank.ForeColor = System.Drawing.Color.White;
            this.btnTotalMoneyInBank.Image = global::BMS_WinForm.Properties.Resources.icons8_money_40;
            this.btnTotalMoneyInBank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTotalMoneyInBank.Location = new System.Drawing.Point(3, 283);
            this.btnTotalMoneyInBank.Name = "btnTotalMoneyInBank";
            this.btnTotalMoneyInBank.Size = new System.Drawing.Size(252, 64);
            this.btnTotalMoneyInBank.TabIndex = 7;
            this.btnTotalMoneyInBank.Text = "Total Money In Bank";
            this.btnTotalMoneyInBank.UseVisualStyleBackColor = false;
            this.btnTotalMoneyInBank.Click += new System.EventHandler(this.btnTotalMoneyInBank_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Image = global::BMS_WinForm.Properties.Resources.icons8_search_40;
            this.btnSearchCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCustomer.Location = new System.Drawing.Point(3, 213);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(252, 64);
            this.btnSearchCustomer.TabIndex = 4;
            this.btnSearchCustomer.Text = "Search Customer";
            this.btnSearchCustomer.UseVisualStyleBackColor = false;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnHome, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(252, 64);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::BMS_WinForm.Properties.Resources.icons8_home_401;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(246, 64);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.btnViewCustomer, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 143);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(252, 64);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnViewCustomer.Image = global::BMS_WinForm.Properties.Resources.icons8_view_40__1_;
            this.btnViewCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomer.Location = new System.Drawing.Point(3, 3);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(246, 58);
            this.btnViewCustomer.TabIndex = 2;
            this.btnViewCustomer.Text = "View Customers";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.adminFeedback1);
            this.panel1.Controls.Add(this.adminHome1);
            this.panel1.Controls.Add(this.totalMoneyInBank1);
            this.panel1.Controls.Add(this.searchCustomer1);
            this.panel1.Controls.Add(this.viewCustomer1);
            this.panel1.Controls.Add(this.addUser1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(267, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 581);
            this.panel1.TabIndex = 1;
            // 
            // adminFeedback1
            // 
            this.adminFeedback1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminFeedback1.Location = new System.Drawing.Point(0, 0);
            this.adminFeedback1.Name = "adminFeedback1";
            this.adminFeedback1.Size = new System.Drawing.Size(758, 581);
            this.adminFeedback1.TabIndex = 5;
            // 
            // adminHome1
            // 
            this.adminHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminHome1.Location = new System.Drawing.Point(0, 0);
            this.adminHome1.Name = "adminHome1";
            this.adminHome1.Size = new System.Drawing.Size(758, 581);
            this.adminHome1.TabIndex = 4;
            // 
            // totalMoneyInBank1
            // 
            this.totalMoneyInBank1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalMoneyInBank1.Location = new System.Drawing.Point(0, 0);
            this.totalMoneyInBank1.Name = "totalMoneyInBank1";
            this.totalMoneyInBank1.Size = new System.Drawing.Size(758, 581);
            this.totalMoneyInBank1.TabIndex = 3;
            // 
            // searchCustomer1
            // 
            this.searchCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchCustomer1.Location = new System.Drawing.Point(0, 0);
            this.searchCustomer1.Name = "searchCustomer1";
            this.searchCustomer1.Size = new System.Drawing.Size(758, 581);
            this.searchCustomer1.TabIndex = 2;
            // 
            // viewCustomer1
            // 
            this.viewCustomer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewCustomer1.Location = new System.Drawing.Point(0, 0);
            this.viewCustomer1.Name = "viewCustomer1";
            this.viewCustomer1.Size = new System.Drawing.Size(758, 581);
            this.viewCustomer1.TabIndex = 1;
            this.viewCustomer1.Load += new System.EventHandler(this.viewCustomer1_Load);
            // 
            // addUser1
            // 
            this.addUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addUser1.Location = new System.Drawing.Point(-6, 0);
            this.addUser1.Name = "addUser1";
            this.addUser1.Size = new System.Drawing.Size(766, 583);
            this.addUser1.TabIndex = 0;
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BMS_WinForm.Properties.Resources.white___Copy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 794);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminWindow";
            this.Load += new System.EventHandler(this.AdminWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private ViewCustomer viewCustomer1;
        private AddUser addUser1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnSearchCustomer;
        private SearchCustomer searchCustomer1;
        private System.Windows.Forms.Button btnTotalMoneyInBank;
        private TotalMoneyInBank totalMoneyInBank1;
        private System.Windows.Forms.Button btnFeedBack;
        private System.Windows.Forms.Button BtnAddUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private AdminHome adminHome1;
        private AdminFeedback adminFeedback1;
    }
}