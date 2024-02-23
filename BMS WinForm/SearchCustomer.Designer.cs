
namespace BMS_WinForm
{
    partial class SearchCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountNumberSearch1 = new BMS_WinForm.AccountNumberSearch();
            this.phoneNumberSearch1 = new BMS_WinForm.PhoneNumberSearch();
            this.citySearch1 = new BMS_WinForm.CitySearch();
            this.userNameSearch1 = new BMS_WinForm.UserNameSearch();
            this.nameSearch1 = new BMS_WinForm.NameSearch();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(856, 641);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.64706F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.52941F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.94118F));
            this.tableLayoutPanel2.Controls.Add(this.cmbSearchBy, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(850, 115);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Name",
            "UserName",
            "City",
            "PhoneNumber",
            "AccountNumber"});
            this.cmbSearchBy.Location = new System.Drawing.Point(254, 41);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(278, 34);
            this.cmbSearchBy.TabIndex = 19;
            this.cmbSearchBy.Text = "SearchBy";
            this.cmbSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbSearchBy_SelectedIndexChanged_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 124);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(850, 514);
            this.tableLayoutPanel3.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.accountNumberSearch1);
            this.panel1.Controls.Add(this.phoneNumberSearch1);
            this.panel1.Controls.Add(this.citySearch1);
            this.panel1.Controls.Add(this.userNameSearch1);
            this.panel1.Controls.Add(this.nameSearch1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 508);
            this.panel1.TabIndex = 0;
            // 
            // accountNumberSearch1
            // 
            this.accountNumberSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountNumberSearch1.Location = new System.Drawing.Point(0, 0);
            this.accountNumberSearch1.Name = "accountNumberSearch1";
            this.accountNumberSearch1.Size = new System.Drawing.Size(844, 508);
            this.accountNumberSearch1.TabIndex = 4;
            this.accountNumberSearch1.Load += new System.EventHandler(this.accountNumberSearch1_Load);
            // 
            // phoneNumberSearch1
            // 
            this.phoneNumberSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneNumberSearch1.Location = new System.Drawing.Point(0, 0);
            this.phoneNumberSearch1.Name = "phoneNumberSearch1";
            this.phoneNumberSearch1.Size = new System.Drawing.Size(844, 508);
            this.phoneNumberSearch1.TabIndex = 3;
            // 
            // citySearch1
            // 
            this.citySearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.citySearch1.Location = new System.Drawing.Point(0, 0);
            this.citySearch1.Name = "citySearch1";
            this.citySearch1.Size = new System.Drawing.Size(844, 508);
            this.citySearch1.TabIndex = 2;
            // 
            // userNameSearch1
            // 
            this.userNameSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameSearch1.Location = new System.Drawing.Point(0, 0);
            this.userNameSearch1.Name = "userNameSearch1";
            this.userNameSearch1.Size = new System.Drawing.Size(844, 508);
            this.userNameSearch1.TabIndex = 1;
            // 
            // nameSearch1
            // 
            this.nameSearch1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameSearch1.Location = new System.Drawing.Point(0, 0);
            this.nameSearch1.Name = "nameSearch1";
            this.nameSearch1.Size = new System.Drawing.Size(844, 508);
            this.nameSearch1.TabIndex = 0;
            // 
            // SearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SearchCustomer";
            this.Size = new System.Drawing.Size(856, 641);
            this.Load += new System.EventHandler(this.SearchCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private NameSearch nameSearch1;
        private AccountNumberSearch accountNumberSearch1;
        private PhoneNumberSearch phoneNumberSearch1;
        private CitySearch citySearch1;
        private UserNameSearch userNameSearch1;
    }
}
