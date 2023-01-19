namespace Session_09 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.ctrlDisplay = new System.Windows.Forms.TextBox();
            this.btnTwo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEqual.Location = new System.Drawing.Point(240, 235);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(62, 39);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddition.Location = new System.Drawing.Point(240, 190);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(62, 39);
            this.btnAddition.TabIndex = 8;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnOne
            // 
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOne.Location = new System.Drawing.Point(25, 235);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(62, 39);
            this.btnOne.TabIndex = 9;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // ctrlDisplay
            // 
            this.ctrlDisplay.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctrlDisplay.Location = new System.Drawing.Point(53, 68);
            this.ctrlDisplay.Name = "ctrlDisplay";
            this.ctrlDisplay.ReadOnly = true;
            this.ctrlDisplay.Size = new System.Drawing.Size(206, 35);
            this.ctrlDisplay.TabIndex = 10;
            // 
            // btnTwo
            // 
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.Location = new System.Drawing.Point(93, 235);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(62, 39);
            this.btnTwo.TabIndex = 11;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 616);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.ctrlDisplay);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnEqual);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnEqual;
        private Button btnAddition;
        private Button btnOne;
        private TextBox ctrlDisplay;
        private Button btnTwo;
        private TextBox textBox1;
    }
}