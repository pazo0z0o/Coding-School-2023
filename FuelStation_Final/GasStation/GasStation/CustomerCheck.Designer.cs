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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Check = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Success
            // 
            this.btn_Success.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Success.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Success.Location = new System.Drawing.Point(108, 212);
            this.btn_Success.Name = "btn_Success";
            this.btn_Success.Size = new System.Drawing.Size(153, 55);
            this.btn_Success.TabIndex = 0;
            this.btn_Success.Text = "Proceed to new Transaction";
            this.btn_Success.UseVisualStyleBackColor = false;
            this.btn_Success.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(108, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 54);
            this.button2.TabIndex = 1;
            this.button2.Text = "Customer Not Found!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 53);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Customer Card Number";
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Gold;
            this.btn_Check.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Check.Location = new System.Drawing.Point(327, 137);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(54, 53);
            this.btn_Check.TabIndex = 4;
            this.btn_Check.Text = "Check";
            this.btn_Check.UseVisualStyleBackColor = false;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // CustomerCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 456);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Success);
            this.Name = "CustomerCheck";
            this.Text = "CustomerCheck";
            this.Load += new System.EventHandler(this.CustomerCheck_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Success;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button btn_Check;
    }
}