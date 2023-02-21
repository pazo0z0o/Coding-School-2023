namespace FuelStation.Win
{
    partial class frm_manager
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
            this.btn_mng_Customer = new System.Windows.Forms.Button();
            this.asskissing_label = new System.Windows.Forms.Label();
            this.btn_mng_Item = new System.Windows.Forms.Button();
            this.btn_mng_Transaction = new System.Windows.Forms.Button();
            this.btn_mng_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mng_Customer
            // 
            this.btn_mng_Customer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_Customer.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_mng_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_mng_Customer.Location = new System.Drawing.Point(504, 211);
            this.btn_mng_Customer.Name = "btn_mng_Customer";
            this.btn_mng_Customer.Size = new System.Drawing.Size(202, 114);
            this.btn_mng_Customer.TabIndex = 0;
            this.btn_mng_Customer.Text = "Customer View";
            this.btn_mng_Customer.UseVisualStyleBackColor = false;
            this.btn_mng_Customer.Click += new System.EventHandler(this.btn_mng_Customer_Click);
            // 
            // asskissing_label
            // 
            this.asskissing_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.asskissing_label.AutoSize = true;
            this.asskissing_label.Location = new System.Drawing.Point(648, 29);
            this.asskissing_label.Name = "asskissing_label";
            this.asskissing_label.Size = new System.Drawing.Size(154, 15);
            this.asskissing_label.TabIndex = 1;
            this.asskissing_label.Text = "Welcome Glorious Manager";
            this.asskissing_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_mng_Item
            // 
            this.btn_mng_Item.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_Item.BackColor = System.Drawing.Color.IndianRed;
            this.btn_mng_Item.Location = new System.Drawing.Point(743, 211);
            this.btn_mng_Item.Name = "btn_mng_Item";
            this.btn_mng_Item.Size = new System.Drawing.Size(202, 114);
            this.btn_mng_Item.TabIndex = 3;
            this.btn_mng_Item.Text = "Items View";
            this.btn_mng_Item.UseVisualStyleBackColor = false;
            this.btn_mng_Item.Click += new System.EventHandler(this.btn_mng_Item_Click);
            // 
            // btn_mng_Transaction
            // 
            this.btn_mng_Transaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mng_Transaction.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_mng_Transaction.Location = new System.Drawing.Point(634, 331);
            this.btn_mng_Transaction.Name = "btn_mng_Transaction";
            this.btn_mng_Transaction.Size = new System.Drawing.Size(202, 114);
            this.btn_mng_Transaction.TabIndex = 4;
            this.btn_mng_Transaction.Text = "Transactions";
            this.btn_mng_Transaction.UseVisualStyleBackColor = false;
            this.btn_mng_Transaction.Click += new System.EventHandler(this.btn_mng_Transaction_Click);
            // 
            // btn_mng_back
            // 
            this.btn_mng_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mng_back.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_mng_back.Location = new System.Drawing.Point(1472, 601);
            this.btn_mng_back.Name = "btn_mng_back";
            this.btn_mng_back.Size = new System.Drawing.Size(65, 30);
            this.btn_mng_back.TabIndex = 6;
            this.btn_mng_back.Text = "BACK ";
            this.btn_mng_back.UseVisualStyleBackColor = false;
            this.btn_mng_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1549, 643);
            this.Controls.Add(this.btn_mng_back);
            this.Controls.Add(this.btn_mng_Transaction);
            this.Controls.Add(this.btn_mng_Item);
            this.Controls.Add(this.asskissing_label);
            this.Controls.Add(this.btn_mng_Customer);
            this.Name = "frm_manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.frm_manager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_mng_Customer;
        private Label asskissing_label;      
        private Button btn_mng_Item;
        private Button btn_mng_Transaction;
        private Button btn_mng_back;
    }
}