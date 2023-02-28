namespace FuelStation.Win
{
    partial class CashierMenu
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
            this.btn_mng_Transaction = new System.Windows.Forms.Button();
            this.btn_mng_Customer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cash_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mng_Transaction
            // 
            this.btn_mng_Transaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_Transaction.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_mng_Transaction.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_mng_Transaction.Location = new System.Drawing.Point(567, 231);
            this.btn_mng_Transaction.Name = "btn_mng_Transaction";
            this.btn_mng_Transaction.Size = new System.Drawing.Size(202, 114);
            this.btn_mng_Transaction.TabIndex = 6;
            this.btn_mng_Transaction.Text = "Transactions";
            this.btn_mng_Transaction.UseVisualStyleBackColor = false;
            this.btn_mng_Transaction.Click += new System.EventHandler(this.btn_mng_Transaction_Click);
            // 
            // btn_mng_Customer
            // 
            this.btn_mng_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_Customer.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_mng_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mng_Customer.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_mng_Customer.Location = new System.Drawing.Point(317, 231);
            this.btn_mng_Customer.Name = "btn_mng_Customer";
            this.btn_mng_Customer.Size = new System.Drawing.Size(202, 114);
            this.btn_mng_Customer.TabIndex = 5;
            this.btn_mng_Customer.Text = "Customers";
            this.btn_mng_Customer.UseVisualStyleBackColor = false;
            this.btn_mng_Customer.Click += new System.EventHandler(this.btn_mng_Customer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(475, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Cashier Choices";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cash_Back
            // 
            this.cash_Back.Location = new System.Drawing.Point(1049, 547);
            this.cash_Back.Name = "cash_Back";
            this.cash_Back.Size = new System.Drawing.Size(83, 37);
            this.cash_Back.TabIndex = 8;
            this.cash_Back.Text = "BACK";
            this.cash_Back.UseVisualStyleBackColor = true;
            this.cash_Back.Click += new System.EventHandler(this.cash_Back_Click);
            // 
            // CashierMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1157, 611);
            this.Controls.Add(this.cash_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mng_Transaction);
            this.Controls.Add(this.btn_mng_Customer);
            this.Name = "CashierMenu";
            this.Text = "CashierMenu";
            this.Load += new System.EventHandler(this.CashierMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_mng_Transaction;
        private Button btn_mng_Customer;
        private Label label1;
        private Button cash_Back;
    }
}