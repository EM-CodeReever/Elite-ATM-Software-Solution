namespace Elite_ATM_Software
{
    partial class FrmDeposit
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtOtherAmount = new System.Windows.Forms.TextBox();
            this.lblDepositAmount = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.cbDepositAmount = new System.Windows.Forms.ComboBox();
            this.lblOther = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(278, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "How Much Would You Like To Deposit?";
            // 
            // txtOtherAmount
            // 
            this.txtOtherAmount.Location = new System.Drawing.Point(227, 160);
            this.txtOtherAmount.Name = "txtOtherAmount";
            this.txtOtherAmount.Size = new System.Drawing.Size(188, 20);
            this.txtOtherAmount.TabIndex = 1;
            this.txtOtherAmount.Visible = false;
            // 
            // lblDepositAmount
            // 
            this.lblDepositAmount.AutoSize = true;
            this.lblDepositAmount.Location = new System.Drawing.Point(54, 129);
            this.lblDepositAmount.Name = "lblDepositAmount";
            this.lblDepositAmount.Size = new System.Drawing.Size(85, 13);
            this.lblDepositAmount.TabIndex = 2;
            this.lblDepositAmount.Text = "Deposit Amount:";
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(164, 206);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(112, 23);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // cbDepositAmount
            // 
            this.cbDepositAmount.FormattingEnabled = true;
            this.cbDepositAmount.Items.AddRange(new object[] {
            "1000",
            "5000",
            "10000",
            "50000",
            "100000",
            "OTHER"});
            this.cbDepositAmount.Location = new System.Drawing.Point(227, 126);
            this.cbDepositAmount.Name = "cbDepositAmount";
            this.cbDepositAmount.Size = new System.Drawing.Size(188, 21);
            this.cbDepositAmount.TabIndex = 4;
            this.cbDepositAmount.SelectedIndexChanged += new System.EventHandler(this.cbDepositAmount_SelectedIndexChanged);
            // 
            // lblOther
            // 
            this.lblOther.AutoSize = true;
            this.lblOther.Location = new System.Drawing.Point(161, 167);
            this.lblOther.Name = "lblOther";
            this.lblOther.Size = new System.Drawing.Size(36, 13);
            this.lblOther.TabIndex = 5;
            this.lblOther.Text = "Other:";
            this.lblOther.Visible = false;
            // 
            // FrmDeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 305);
            this.Controls.Add(this.lblOther);
            this.Controls.Add(this.cbDepositAmount);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblDepositAmount);
            this.Controls.Add(this.txtOtherAmount);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmDeposit";
            this.Text = "FrmDeposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtOtherAmount;
        private System.Windows.Forms.Label lblDepositAmount;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.ComboBox cbDepositAmount;
        private System.Windows.Forms.Label lblOther;
    }
}