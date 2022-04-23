namespace Elite_ATM_Software
{
    partial class FrmWithdraw
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
            this.lblOther = new System.Windows.Forms.Label();
            this.cbWithdrawAmount = new System.Windows.Forms.ComboBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblWithdrawAmount = new System.Windows.Forms.Label();
            this.txtOtherAmount = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(201, 186);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(36, 13);
            this.lblOther.TabIndex = 11;
            this.lblOther.Text = "Other:";
            this.lblOther.Visible = false;
            // 
            // cbWithdrawAmount
            // 
            this.cbWithdrawAmount.FormattingEnabled = true;
            this.cbWithdrawAmount.Items.AddRange(new object[] {
            "1000",
            "5000",
            "10000",
            "50000",
            "100000",
            "OTHER"});
            this.cbWithdrawAmount.Location = new System.Drawing.Point(267, 145);
            this.cbWithdrawAmount.Name = "cbWithdrawAmount";
            this.cbWithdrawAmount.Size = new System.Drawing.Size(188, 21);
            this.cbWithdrawAmount.TabIndex = 10;
            this.cbWithdrawAmount.SelectedIndexChanged += new System.EventHandler(this.cbWithdrawAmount_SelectedIndexChanged);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(204, 225);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(112, 23);
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Text = "Make Withdrawl";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // lblWithdrawAmount
            // 
            this.lblWithdrawAmount.AutoSize = true;
            this.lblWithdrawAmount.Location = new System.Drawing.Point(86, 145);
            this.lblWithdrawAmount.Name = "lblWithdrawAmount";
            this.lblWithdrawAmount.Size = new System.Drawing.Size(96, 13);
            this.lblWithdrawAmount.TabIndex = 8;
            this.lblWithdrawAmount.Text = "Withdrawl Amount:";
            // 
            // txtOtherAmount
            // 
            this.txtOtherAmount.Location = new System.Drawing.Point(267, 179);
            this.txtOtherAmount.Name = "txtOtherAmount";
            this.txtOtherAmount.Size = new System.Drawing.Size(188, 20);
            this.txtOtherAmount.TabIndex = 7;
            this.txtOtherAmount.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(116, 85);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(287, 16);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "How Much Would You Like To Withdraw?";
            // 
            // FrmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 325);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.cbWithdrawAmount);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblWithdrawAmount);
            this.Controls.Add(this.txtOtherAmount);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmWithdraw";
            this.Text = "FrmWithdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOther;
        private System.Windows.Forms.ComboBox cbWithdrawAmount;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblWithdrawAmount;
        private System.Windows.Forms.TextBox txtOtherAmount;
        private System.Windows.Forms.Label lblTitle;
    }
}