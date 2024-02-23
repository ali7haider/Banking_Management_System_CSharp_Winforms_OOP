
namespace BMS_WinForm
{
    partial class BalanceDetailsCus
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAvailableDetails = new System.Windows.Forms.TextBox();
            this.txtWithDrawMoneyDetails = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIntialBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewTransactHistory = new System.Windows.Forms.Button();
            this.txtDepositDetails = new System.Windows.Forms.TextBox();
            this.txtTransactDetails = new System.Windows.Forms.TextBox();
            this.txtReceivedDetails = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(14, 321);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(184, 67);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 58);
            this.label8.TabIndex = 4;
            this.label8.Text = "Received Money :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Available Balance :";
            // 
            // txtAvailableDetails
            // 
            this.txtAvailableDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAvailableDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableDetails.Location = new System.Drawing.Point(204, 394);
            this.txtAvailableDetails.Name = "txtAvailableDetails";
            this.txtAvailableDetails.ReadOnly = true;
            this.txtAvailableDetails.Size = new System.Drawing.Size(657, 36);
            this.txtAvailableDetails.TabIndex = 3;
            // 
            // txtWithDrawMoneyDetails
            // 
            this.txtWithDrawMoneyDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWithDrawMoneyDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWithDrawMoneyDetails.Location = new System.Drawing.Point(14, 264);
            this.txtWithDrawMoneyDetails.Name = "txtWithDrawMoneyDetails";
            this.txtWithDrawMoneyDetails.ReadOnly = true;
            this.txtWithDrawMoneyDetails.Size = new System.Drawing.Size(184, 36);
            this.txtWithDrawMoneyDetails.TabIndex = 1;
            this.txtWithDrawMoneyDetails.TextChanged += new System.EventHandler(this.txtWithDrawMoneyDetails_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transact Money";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "WithDraw Money :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Amount :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.153846F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.667482F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.25428F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 662F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtWithDrawMoneyDetails, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTransactDetails, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtAvailableDetails, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label7, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtReceivedDetails, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRefresh, 3, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.71751F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.94915F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.68927F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.64407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(864, 492);
            this.tableLayoutPanel1.TabIndex = 7;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 2);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 647F));
            this.tableLayoutPanel3.Controls.Add(this.txtIntialBalance, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnViewTransactHistory, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtDepositDetails, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(14, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(847, 189);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // txtIntialBalance
            // 
            this.txtIntialBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIntialBalance.Location = new System.Drawing.Point(3, 139);
            this.txtIntialBalance.Name = "txtIntialBalance";
            this.txtIntialBalance.ReadOnly = true;
            this.txtIntialBalance.Size = new System.Drawing.Size(194, 36);
            this.txtIntialBalance.TabIndex = 1;
            this.txtIntialBalance.TextChanged += new System.EventHandler(this.txtIntialBalance_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Deposit Money :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Intial Deposit :";
            // 
            // btnViewTransactHistory
            // 
            this.btnViewTransactHistory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.SetColumnSpan(this.btnViewTransactHistory, 2);
            this.btnViewTransactHistory.ForeColor = System.Drawing.Color.White;
            this.btnViewTransactHistory.Image = global::BMS_WinForm.Properties.Resources.blueback;
            this.btnViewTransactHistory.Location = new System.Drawing.Point(285, 22);
            this.btnViewTransactHistory.Name = "btnViewTransactHistory";
            this.btnViewTransactHistory.Size = new System.Drawing.Size(277, 58);
            this.btnViewTransactHistory.TabIndex = 4;
            this.btnViewTransactHistory.Text = "Balance Details";
            this.btnViewTransactHistory.UseVisualStyleBackColor = true;
            // 
            // txtDepositDetails
            // 
            this.txtDepositDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDepositDetails.Location = new System.Drawing.Point(203, 139);
            this.txtDepositDetails.Name = "txtDepositDetails";
            this.txtDepositDetails.ReadOnly = true;
            this.txtDepositDetails.Size = new System.Drawing.Size(641, 36);
            this.txtDepositDetails.TabIndex = 5;
            this.txtDepositDetails.TextChanged += new System.EventHandler(this.txtDepositDetails_TextChanged);
            // 
            // txtTransactDetails
            // 
            this.txtTransactDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTransactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactDetails.Location = new System.Drawing.Point(204, 264);
            this.txtTransactDetails.Name = "txtTransactDetails";
            this.txtTransactDetails.ReadOnly = true;
            this.txtTransactDetails.Size = new System.Drawing.Size(657, 36);
            this.txtTransactDetails.TabIndex = 8;
            this.txtTransactDetails.TextChanged += new System.EventHandler(this.txtTransactDetails_TextChanged);
            // 
            // txtReceivedDetails
            // 
            this.txtReceivedDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReceivedDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedDetails.Location = new System.Drawing.Point(14, 394);
            this.txtReceivedDetails.Name = "txtReceivedDetails";
            this.txtReceivedDetails.ReadOnly = true;
            this.txtReceivedDetails.Size = new System.Drawing.Size(184, 36);
            this.txtReceivedDetails.TabIndex = 9;
            this.txtReceivedDetails.TextChanged += new System.EventHandler(this.txtReceivedDetails_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRefresh.BackgroundImage = global::BMS_WinForm.Properties.Resources.bluebackground;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(736, 449);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(125, 40);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // BalanceDetailsCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BalanceDetailsCus";
            this.Size = new System.Drawing.Size(864, 492);
            this.Load += new System.EventHandler(this.BalanceDetailsCus_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAvailableDetails;
        private System.Windows.Forms.TextBox txtWithDrawMoneyDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtIntialBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewTransactHistory;
        private System.Windows.Forms.TextBox txtDepositDetails;
        private System.Windows.Forms.TextBox txtTransactDetails;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReceivedDetails;
        private System.Windows.Forms.Button btnRefresh;
    }
}
