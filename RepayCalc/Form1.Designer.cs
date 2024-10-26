namespace RepayCalc
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.txtPrincipal = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.cmbPaymentFrequency = new System.Windows.Forms.ComboBox();
            this.LblPaymentAmount = new System.Windows.Forms.Label();
            this.LblAnnualInterest = new System.Windows.Forms.Label();
            this.LblPaymentFrequency = new System.Windows.Forms.Label();
            this.LblLoanAmount = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRemainingDebt = new System.Windows.Forms.TextBox();
            this.LblRemainingDebt = new System.Windows.Forms.Label();
            this.dataGridViewAmortization = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortization)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LblRemainingDebt);
            this.tabPage1.Controls.Add(this.txtRemainingDebt);
            this.tabPage1.Controls.Add(this.txtResult);
            this.tabPage1.Controls.Add(this.btnCalculate);
            this.tabPage1.Controls.Add(this.lblResult);
            this.tabPage1.Controls.Add(this.txtPaymentAmount);
            this.tabPage1.Controls.Add(this.txtPrincipal);
            this.tabPage1.Controls.Add(this.txtInterestRate);
            this.tabPage1.Controls.Add(this.cmbPaymentFrequency);
            this.tabPage1.Controls.Add(this.LblPaymentAmount);
            this.tabPage1.Controls.Add(this.LblAnnualInterest);
            this.tabPage1.Controls.Add(this.LblPaymentFrequency);
            this.tabPage1.Controls.Add(this.LblLoanAmount);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Repayment time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(366, 47);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(304, 70);
            this.txtResult.TabIndex = 16;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(318, 275);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(470, 84);
            this.lblResult.MinimumSize = new System.Drawing.Size(200, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(200, 13);
            this.lblResult.TabIndex = 13;
            // 
            // txtPaymentAmount
            // 
            this.txtPaymentAmount.Location = new System.Drawing.Point(165, 204);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(100, 20);
            this.txtPaymentAmount.TabIndex = 11;
            // 
            // txtPrincipal
            // 
            this.txtPrincipal.Location = new System.Drawing.Point(165, 47);
            this.txtPrincipal.Name = "txtPrincipal";
            this.txtPrincipal.Size = new System.Drawing.Size(121, 20);
            this.txtPrincipal.TabIndex = 10;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(165, 125);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 20);
            this.txtInterestRate.TabIndex = 9;
            // 
            // cmbPaymentFrequency
            // 
            this.cmbPaymentFrequency.FormattingEnabled = true;
            this.cmbPaymentFrequency.Items.AddRange(new object[] {
            "Monthly",
            "Fortnightly",
            "Weekly"});
            this.cmbPaymentFrequency.Location = new System.Drawing.Point(165, 164);
            this.cmbPaymentFrequency.Name = "cmbPaymentFrequency";
            this.cmbPaymentFrequency.Size = new System.Drawing.Size(121, 21);
            this.cmbPaymentFrequency.TabIndex = 8;
            // 
            // LblPaymentAmount
            // 
            this.LblPaymentAmount.AutoSize = true;
            this.LblPaymentAmount.Location = new System.Drawing.Point(57, 210);
            this.LblPaymentAmount.Name = "LblPaymentAmount";
            this.LblPaymentAmount.Size = new System.Drawing.Size(86, 13);
            this.LblPaymentAmount.TabIndex = 7;
            this.LblPaymentAmount.Text = "Payment amount";
            // 
            // LblAnnualInterest
            // 
            this.LblAnnualInterest.AutoSize = true;
            this.LblAnnualInterest.Location = new System.Drawing.Point(45, 132);
            this.LblAnnualInterest.Name = "LblAnnualInterest";
            this.LblAnnualInterest.Size = new System.Drawing.Size(98, 13);
            this.LblAnnualInterest.TabIndex = 6;
            this.LblAnnualInterest.Text = "Annual interest rate";
            // 
            // LblPaymentFrequency
            // 
            this.LblPaymentFrequency.AutoSize = true;
            this.LblPaymentFrequency.Location = new System.Drawing.Point(45, 171);
            this.LblPaymentFrequency.Name = "LblPaymentFrequency";
            this.LblPaymentFrequency.Size = new System.Drawing.Size(98, 13);
            this.LblPaymentFrequency.TabIndex = 5;
            this.LblPaymentFrequency.Text = "Payment frequency";
            // 
            // LblLoanAmount
            // 
            this.LblLoanAmount.AutoSize = true;
            this.LblLoanAmount.Location = new System.Drawing.Point(74, 54);
            this.LblLoanAmount.Name = "LblLoanAmount";
            this.LblLoanAmount.Size = new System.Drawing.Size(69, 13);
            this.LblLoanAmount.TabIndex = 4;
            this.LblLoanAmount.Text = "Loan amount";
            this.LblLoanAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewAmortization);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Amortization details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtRemainingDebt
            // 
            this.txtRemainingDebt.Location = new System.Drawing.Point(165, 86);
            this.txtRemainingDebt.Name = "txtRemainingDebt";
            this.txtRemainingDebt.Size = new System.Drawing.Size(100, 20);
            this.txtRemainingDebt.TabIndex = 17;
            // 
            // LblRemainingDebt
            // 
            this.LblRemainingDebt.AutoSize = true;
            this.LblRemainingDebt.Location = new System.Drawing.Point(62, 93);
            this.LblRemainingDebt.Name = "LblRemainingDebt";
            this.LblRemainingDebt.Size = new System.Drawing.Size(81, 13);
            this.LblRemainingDebt.TabIndex = 18;
            this.LblRemainingDebt.Text = "Remaining debt";
            // 
            // dataGridViewAmortization
            // 
            this.dataGridViewAmortization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmortization.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAmortization.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAmortization.Name = "dataGridViewAmortization";
            this.dataGridViewAmortization.Size = new System.Drawing.Size(762, 394);
            this.dataGridViewAmortization.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mortgage calculator";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmortization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label LblPaymentAmount;
        private System.Windows.Forms.Label LblAnnualInterest;
        private System.Windows.Forms.Label LblPaymentFrequency;
        private System.Windows.Forms.Label LblLoanAmount;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtPaymentAmount;
        private System.Windows.Forms.TextBox txtPrincipal;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.ComboBox cmbPaymentFrequency;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label LblRemainingDebt;
        private System.Windows.Forms.TextBox txtRemainingDebt;
        private System.Windows.Forms.DataGridView dataGridViewAmortization;
    }
}

