namespace GasStation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Manager = new System.Windows.Forms.Button();
            this.btn_Cashier = new System.Windows.Forms.Button();
            this.btn_Staff = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btn_Manager
            // 
            this.btn_Manager.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Manager.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Manager.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_Manager.Location = new System.Drawing.Point(0, 0);
            this.btn_Manager.Name = "btn_Manager";
            this.btn_Manager.Size = new System.Drawing.Size(220, 707);
            this.btn_Manager.TabIndex = 0;
            this.btn_Manager.Text = "Manager ";
            this.btn_Manager.UseVisualStyleBackColor = false;
            this.btn_Manager.Click += new System.EventHandler(this.btn_Manager_Click);
            // 
            // btn_Cashier
            // 
            this.btn_Cashier.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Cashier.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cashier.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_Cashier.Location = new System.Drawing.Point(220, 0);
            this.btn_Cashier.Name = "btn_Cashier";
            this.btn_Cashier.Size = new System.Drawing.Size(220, 707);
            this.btn_Cashier.TabIndex = 1;
            this.btn_Cashier.Text = "Cashier";
            this.btn_Cashier.UseVisualStyleBackColor = false;
            this.btn_Cashier.Click += new System.EventHandler(this.btn_Cashier_Click);
            // 
            // btn_Staff
            // 
            this.btn_Staff.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_Staff.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Staff.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btn_Staff.Location = new System.Drawing.Point(440, 0);
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.Size = new System.Drawing.Size(220, 707);
            this.btn_Staff.TabIndex = 2;
            this.btn_Staff.Text = "Staff";
            this.btn_Staff.UseVisualStyleBackColor = false;
            this.btn_Staff.Click += new System.EventHandler(this.btn_Staff_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(706, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(599, 235);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(1331, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1558, 707);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Staff);
            this.Controls.Add(this.btn_Cashier);
            this.Controls.Add(this.btn_Manager);
            this.Name = "Form1";
            this.Text = "Landing Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Manager;
        private Button btn_Cashier;
        private Button btn_Staff;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
    }
}