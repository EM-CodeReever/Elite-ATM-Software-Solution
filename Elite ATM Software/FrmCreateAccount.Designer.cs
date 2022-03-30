namespace Elite_ATM_Software
{
    partial class FrmCreateAccount
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
            this.cbCurrency = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPersonalAccountType = new System.Windows.Forms.ComboBox();
            this.lblChoosePersonalAccountType = new System.Windows.Forms.Label();
            this.rbBusiness = new System.Windows.Forms.RadioButton();
            this.rbPersonal = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.lblEliteATM = new System.Windows.Forms.Label();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbCurrency
            // 
            this.cbCurrency.FormattingEnabled = true;
            this.cbCurrency.Items.AddRange(new object[] {
            "JMD",
            "USD",
            "CAD",
            "EUR"});
            this.cbCurrency.Location = new System.Drawing.Point(359, 252);
            this.cbCurrency.Name = "cbCurrency";
            this.cbCurrency.Size = new System.Drawing.Size(121, 21);
            this.cbCurrency.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Currency";
            // 
            // cbPersonalAccountType
            // 
            this.cbPersonalAccountType.FormattingEnabled = true;
            this.cbPersonalAccountType.Items.AddRange(new object[] {
            "Chequing",
            "Savings"});
            this.cbPersonalAccountType.Location = new System.Drawing.Point(262, 218);
            this.cbPersonalAccountType.Name = "cbPersonalAccountType";
            this.cbPersonalAccountType.Size = new System.Drawing.Size(218, 21);
            this.cbPersonalAccountType.TabIndex = 22;
            this.cbPersonalAccountType.Visible = false;
            // 
            // lblChoosePersonalAccountType
            // 
            this.lblChoosePersonalAccountType.AutoSize = true;
            this.lblChoosePersonalAccountType.Location = new System.Drawing.Point(93, 221);
            this.lblChoosePersonalAccountType.Name = "lblChoosePersonalAccountType";
            this.lblChoosePersonalAccountType.Size = new System.Drawing.Size(160, 13);
            this.lblChoosePersonalAccountType.TabIndex = 21;
            this.lblChoosePersonalAccountType.Text = "Choose a personal account type";
            this.lblChoosePersonalAccountType.Visible = false;
            // 
            // rbBusiness
            // 
            this.rbBusiness.AutoSize = true;
            this.rbBusiness.Checked = true;
            this.rbBusiness.Location = new System.Drawing.Point(413, 190);
            this.rbBusiness.Name = "rbBusiness";
            this.rbBusiness.Size = new System.Drawing.Size(67, 17);
            this.rbBusiness.TabIndex = 20;
            this.rbBusiness.TabStop = true;
            this.rbBusiness.Text = "Business";
            this.rbBusiness.UseVisualStyleBackColor = true;
            // 
            // rbPersonal
            // 
            this.rbPersonal.AutoSize = true;
            this.rbPersonal.Location = new System.Drawing.Point(262, 190);
            this.rbPersonal.Name = "rbPersonal";
            this.rbPersonal.Size = new System.Drawing.Size(66, 17);
            this.rbPersonal.TabIndex = 19;
            this.rbPersonal.Text = "Personal";
            this.rbPersonal.UseVisualStyleBackColor = true;
            this.rbPersonal.CheckedChanged += new System.EventHandler(this.rbPersonal_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Account Type";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(171, 88);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(225, 20);
            this.lblSubTitle.TabIndex = 26;
            this.lblSubTitle.Text = "Account Managemnt Software";
            // 
            // lblEliteATM
            // 
            this.lblEliteATM.AutoSize = true;
            this.lblEliteATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliteATM.Location = new System.Drawing.Point(199, 55);
            this.lblEliteATM.Name = "lblEliteATM";
            this.lblEliteATM.Size = new System.Drawing.Size(173, 33);
            this.lblEliteATM.TabIndex = 25;
            this.lblEliteATM.Text = "ELITE ATM";
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(236, 315);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(112, 35);
            this.btnOpenAccount.TabIndex = 27;
            this.btnOpenAccount.Text = "Open Account";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(396, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 20);
            this.textBox1.TabIndex = 28;
            // 
            // FrmCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblEliteATM);
            this.Controls.Add(this.cbCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPersonalAccountType);
            this.Controls.Add(this.lblChoosePersonalAccountType);
            this.Controls.Add(this.rbBusiness);
            this.Controls.Add(this.rbPersonal);
            this.Controls.Add(this.label4);
            this.Name = "FrmCreateAccount";
            this.Text = "FrmCreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCurrency;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPersonalAccountType;
        private System.Windows.Forms.Label lblChoosePersonalAccountType;
        private System.Windows.Forms.RadioButton rbBusiness;
        private System.Windows.Forms.RadioButton rbPersonal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblEliteATM;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.TextBox textBox1;
    }
}