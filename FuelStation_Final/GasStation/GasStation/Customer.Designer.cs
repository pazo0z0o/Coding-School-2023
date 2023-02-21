namespace FuelStation.Win
{
    partial class Customer_frm
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
            this.grv_Items = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Items)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Items
            // 
            this.grv_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Name,
            this.col_Surname,
            this.col_CardNum});
            this.grv_Items.Location = new System.Drawing.Point(34, 39);
            this.grv_Items.Name = "grv_Items";
            this.grv_Items.RowTemplate.Height = 25;
            this.grv_Items.Size = new System.Drawing.Size(364, 118);
            this.grv_Items.TabIndex = 0;
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "Customer ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = false;
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            // 
            // col_Surname
            // 
            this.col_Surname.HeaderText = "Surname";
            this.col_Surname.Name = "col_Surname";
            // 
            // col_CardNum
            // 
            this.col_CardNum.HeaderText = "Card Number";
            this.col_CardNum.Name = "col_CardNum";
            // 
            // Customer_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grv_Items);
            this.Name = "Customer_frm";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.grv_Items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Items;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewTextBoxColumn col_Surname;
        private DataGridViewTextBoxColumn col_CardNum;
    }
}