namespace Elite_ATM_Software
{
    partial class FrmHome
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnlAccountInfo = new System.Windows.Forms.Panel();
            this.txtAccountType = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtAccountHolder = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblAccountHolder = new System.Windows.Forms.Label();
            this.lblAccountInformation = new System.Windows.Forms.Label();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.bntEditAccountDetails = new System.Windows.Forms.Button();
            this.pnlPageTitle = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNoAccountOpen = new System.Windows.Forms.Label();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAccountInfo.SuspendLayout();
            this.pnlSidePanel.SuspendLayout();
            this.pnlPageTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(49, 409);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 29);
            this.btnLogOut.TabIndex = 0;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnlAccountInfo
            // 
            this.pnlAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccountInfo.Controls.Add(this.txtAccountType);
            this.pnlAccountInfo.Controls.Add(this.lblAccountType);
            this.pnlAccountInfo.Controls.Add(this.btnDeposit);
            this.pnlAccountInfo.Controls.Add(this.btnWithdraw);
            this.pnlAccountInfo.Controls.Add(this.txtCurrency);
            this.pnlAccountInfo.Controls.Add(this.txtAccountHolder);
            this.pnlAccountInfo.Controls.Add(this.txtBalance);
            this.pnlAccountInfo.Controls.Add(this.lblBalance);
            this.pnlAccountInfo.Controls.Add(this.lblCurrency);
            this.pnlAccountInfo.Controls.Add(this.lblAccountHolder);
            this.pnlAccountInfo.Location = new System.Drawing.Point(238, 115);
            this.pnlAccountInfo.Name = "pnlAccountInfo";
            this.pnlAccountInfo.Size = new System.Drawing.Size(520, 232);
            this.pnlAccountInfo.TabIndex = 1;
            this.pnlAccountInfo.Visible = false;
            // 
            // txtAccountType
            // 
            this.txtAccountType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountType.Location = new System.Drawing.Point(306, 67);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.ReadOnly = true;
            this.txtAccountType.Size = new System.Drawing.Size(168, 20);
            this.txtAccountType.TabIndex = 12;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(34, 67);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(91, 15);
            this.lblAccountType.TabIndex = 11;
            this.lblAccountType.Text = "Account Type";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.Location = new System.Drawing.Point(306, 183);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(75, 29);
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(156, 183);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(75, 29);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrency.Location = new System.Drawing.Point(306, 92);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(168, 20);
            this.txtCurrency.TabIndex = 8;
            // 
            // txtAccountHolder
            // 
            this.txtAccountHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccountHolder.Location = new System.Drawing.Point(306, 41);
            this.txtAccountHolder.Name = "txtAccountHolder";
            this.txtAccountHolder.ReadOnly = true;
            this.txtAccountHolder.Size = new System.Drawing.Size(168, 20);
            this.txtAccountHolder.TabIndex = 7;
            // 
            // txtBalance
            // 
            this.txtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.ForeColor = System.Drawing.Color.Green;
            this.txtBalance.Location = new System.Drawing.Point(306, 118);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(168, 21);
            this.txtBalance.TabIndex = 6;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(34, 118);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(59, 15);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency.Location = new System.Drawing.Point(34, 92);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(63, 15);
            this.lblCurrency.TabIndex = 3;
            this.lblCurrency.Text = "Currency";
            // 
            // lblAccountHolder
            // 
            this.lblAccountHolder.AutoSize = true;
            this.lblAccountHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountHolder.Location = new System.Drawing.Point(34, 41);
            this.lblAccountHolder.Name = "lblAccountHolder";
            this.lblAccountHolder.Size = new System.Drawing.Size(104, 15);
            this.lblAccountHolder.TabIndex = 0;
            this.lblAccountHolder.Text = "Account Holder";
            // 
            // lblAccountInformation
            // 
            this.lblAccountInformation.AutoSize = true;
            this.lblAccountInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAccountInformation.Location = new System.Drawing.Point(234, 66);
            this.lblAccountInformation.Name = "lblAccountInformation";
            this.lblAccountInformation.Size = new System.Drawing.Size(196, 24);
            this.lblAccountInformation.TabIndex = 0;
            this.lblAccountInformation.Text = "Account Information";
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSidePanel.Controls.Add(this.btnUserProfile);
            this.pnlSidePanel.Controls.Add(this.bntEditAccountDetails);
            this.pnlSidePanel.Controls.Add(this.pnlPageTitle);
            this.pnlSidePanel.Controls.Add(this.btnLogOut);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidePanel.Location = new System.Drawing.Point(0, 0);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(184, 460);
            this.pnlSidePanel.TabIndex = 2;
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserProfile.Location = new System.Drawing.Point(0, 154);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(184, 44);
            this.btnUserProfile.TabIndex = 4;
            this.btnUserProfile.Text = "User Profile";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            // 
            // bntEditAccountDetails
            // 
            this.bntEditAccountDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.bntEditAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntEditAccountDetails.Location = new System.Drawing.Point(0, 109);
            this.bntEditAccountDetails.Name = "bntEditAccountDetails";
            this.bntEditAccountDetails.Size = new System.Drawing.Size(184, 45);
            this.bntEditAccountDetails.TabIndex = 3;
            this.bntEditAccountDetails.Text = "Edit Accunt Details";
            this.bntEditAccountDetails.UseVisualStyleBackColor = true;
            // 
            // pnlPageTitle
            // 
            this.pnlPageTitle.Controls.Add(this.label6);
            this.pnlPageTitle.Controls.Add(this.label4);
            this.pnlPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPageTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlPageTitle.Name = "pnlPageTitle";
            this.pnlPageTitle.Size = new System.Drawing.Size(184, 109);
            this.pnlPageTitle.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Account Management Software";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(45, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elite ATM";
            // 
            // lblNoAccountOpen
            // 
            this.lblNoAccountOpen.AutoSize = true;
            this.lblNoAccountOpen.Location = new System.Drawing.Point(238, 94);
            this.lblNoAccountOpen.Name = "lblNoAccountOpen";
            this.lblNoAccountOpen.Size = new System.Drawing.Size(184, 13);
            this.lblNoAccountOpen.TabIndex = 3;
            this.lblNoAccountOpen.Text = "You Havent Opened  An Account yet";
            this.lblNoAccountOpen.Visible = false;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(428, 89);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(98, 23);
            this.btnOpenAccount.TabIndex = 4;
            this.btnOpenAccount.Text = "Open Account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Visible = false;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.White;
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(754, 439);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(34, 15);
            this.txtUserID.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Logged In with UserID:";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.lblNoAccountOpen);
            this.Controls.Add(this.pnlSidePanel);
            this.Controls.Add(this.lblAccountInformation);
            this.Controls.Add(this.pnlAccountInfo);
            this.Name = "FrmHome";
            this.Text = "Elite ATM Software";
            this.pnlAccountInfo.ResumeLayout(false);
            this.pnlAccountInfo.PerformLayout();
            this.pnlSidePanel.ResumeLayout(false);
            this.pnlPageTitle.ResumeLayout(false);
            this.pnlPageTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnlAccountInfo;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblAccountHolder;
        private System.Windows.Forms.Label lblAccountInformation;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtAccountHolder;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.Panel pnlPageTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntEditAccountDetails;
        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.TextBox txtAccountType;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblNoAccountOpen;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label1;
    }
}

