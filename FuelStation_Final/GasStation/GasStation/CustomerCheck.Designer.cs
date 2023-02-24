namespace FuelStation.Win
{
    partial class CustomerCheck
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
            this.btn_Success = new System.Windows.Forms.Button();
            this.btn_CreateCustomer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Success
            // 
            this.btn_Success.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Success.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Success.Location = new System.Drawing.Point(107, 233);
            this.btn_Success.Name = "btn_Success";
            this.btn_Success.Size = new System.Drawing.Size(153, 55);
            this.btn_Success.TabIndex = 0;
            this.btn_Success.Text = "Proceed to new Transaction";
            this.btn_Success.UseVisualStyleBackColor = false;
            this.btn_Success.Visible = false;
            this.btn_Success.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_CreateCustomer
            // 
            this.btn_CreateCustomer.BackColor = System.Drawing.Color.Red;
            this.btn_CreateCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CreateCustomer.Location = new System.Drawing.Point(107, 294);
            this.btn_CreateCustomer.Name = "btn_CreateCustomer";
            this.btn_CreateCustomer.Size = new System.Drawing.Size(153, 54);
            this.btn_CreateCustomer.TabIndex = 1;
            this.btn_CreateCustomer.Text = "Customer Not Found!";
            this.btn_CreateCustomer.UseVisualStyleBackColor = false;
            this.btn_CreateCustomer.Visible = false;
            this.btn_CreateCustomer.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(23, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Enter Card Number";
            this.textBox1.Size = new System.Drawing.Size(298, 39);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Customer Card Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Gold;
            this.btn_Check.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Check.Location = new System.Drawing.Point(327, 124);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(54, 39);
            this.btn_Check.TabIndex = 4;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_back.Location = new System.Drawing.Point(147, 381);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(80, 36);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "BACK";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.Color.SlateBlue;
            this.btn_clear.Location = new System.Drawing.Point(23, 169);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(88, 30);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // CustomerCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 456);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_CreateCustomer);
            this.Controls.Add(this.btn_Success);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CustomerCheck";
            this.Text = "CustomerCheck";
            this.Load += new System.EventHandler(this.CustomerCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Success;
        private Button btn_CreateCustomer;
        private TextBox textBox1;
        private Label label1;
        private Button btn_Check;
        private Button btn_back;
        private Button btn_clear;
    }
}