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
            this.components = new System.ComponentModel.Container();
            this.grv_Customers = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CardNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Customer_Add = new System.Windows.Forms.Button();
            this.btn_Customer_edit = new System.Windows.Forms.Button();
            this.btn_Customer_delete = new System.Windows.Forms.Button();
            this.btn_Customer_Load = new System.Windows.Forms.Button();
            this.btn_Customer_save = new System.Windows.Forms.Button();
            this.cash_Back = new System.Windows.Forms.Button();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Customers
            // 
            this.grv_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Name,
            this.col_Surname,
            this.col_CardNum});
            this.grv_Customers.Location = new System.Drawing.Point(21, 64);
            this.grv_Customers.Name = "grv_Customers";
            this.grv_Customers.RowTemplate.Height = 25;
            this.grv_Customers.Size = new System.Drawing.Size(604, 135);
            this.grv_Customers.TabIndex = 0;
            this.grv_Customers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Items_CellContentClick);
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "ID";
            this.col_ID.HeaderText = "Customer ID";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = false;
            // 
            // col_Name
            // 
            this.col_Name.DataPropertyName = "Name";
            this.col_Name.HeaderText = "Name";
            this.col_Name.Name = "col_Name";
            // 
            // col_Surname
            // 
            this.col_Surname.DataPropertyName = "Surname";
            this.col_Surname.HeaderText = "Surname";
            this.col_Surname.Name = "col_Surname";
            // 
            // col_CardNum
            // 
            this.col_CardNum.DataPropertyName = "CardNumber";
            this.col_CardNum.HeaderText = "Card Number";
            this.col_CardNum.Name = "col_CardNum";
            // 
            // btn_Customer_Add
            // 
            this.btn_Customer_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Customer_Add.Location = new System.Drawing.Point(695, 160);
            this.btn_Customer_Add.Name = "btn_Customer_Add";
            this.btn_Customer_Add.Size = new System.Drawing.Size(50, 39);
            this.btn_Customer_Add.TabIndex = 15;
            this.btn_Customer_Add.Text = "+Add";
            this.btn_Customer_Add.UseVisualStyleBackColor = false;
            this.btn_Customer_Add.Click += new System.EventHandler(this.btn_Customer_Add_Click);
            // 
            // btn_Customer_edit
            // 
            this.btn_Customer_edit.BackColor = System.Drawing.Color.Salmon;
            this.btn_Customer_edit.Location = new System.Drawing.Point(641, 160);
            this.btn_Customer_edit.Name = "btn_Customer_edit";
            this.btn_Customer_edit.Size = new System.Drawing.Size(48, 39);
            this.btn_Customer_edit.TabIndex = 14;
            this.btn_Customer_edit.Text = "Edit";
            this.btn_Customer_edit.UseVisualStyleBackColor = false;
            // 
            // btn_Customer_delete
            // 
            this.btn_Customer_delete.BackColor = System.Drawing.Color.Red;
            this.btn_Customer_delete.Location = new System.Drawing.Point(695, 205);
            this.btn_Customer_delete.Name = "btn_Customer_delete";
            this.btn_Customer_delete.Size = new System.Drawing.Size(49, 39);
            this.btn_Customer_delete.TabIndex = 13;
            this.btn_Customer_delete.Text = "DEL";
            this.btn_Customer_delete.UseVisualStyleBackColor = false;
            // 
            // btn_Customer_Load
            // 
            this.btn_Customer_Load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Customer_Load.Location = new System.Drawing.Point(641, 109);
            this.btn_Customer_Load.Name = "btn_Customer_Load";
            this.btn_Customer_Load.Size = new System.Drawing.Size(104, 39);
            this.btn_Customer_Load.TabIndex = 12;
            this.btn_Customer_Load.Text = "Load";
            this.btn_Customer_Load.UseVisualStyleBackColor = false;
            this.btn_Customer_Load.Click += new System.EventHandler(this.btn_Customer_Load_Click);
            // 
            // btn_Customer_save
            // 
            this.btn_Customer_save.BackColor = System.Drawing.Color.Gold;
            this.btn_Customer_save.Location = new System.Drawing.Point(641, 64);
            this.btn_Customer_save.Name = "btn_Customer_save";
            this.btn_Customer_save.Size = new System.Drawing.Size(104, 39);
            this.btn_Customer_save.TabIndex = 11;
            this.btn_Customer_save.Text = "Save";
            this.btn_Customer_save.UseVisualStyleBackColor = false;
            this.btn_Customer_save.Click += new System.EventHandler(this.btn_Customer_save_Click);
            // 
            // cash_Back
            // 
            this.cash_Back.Location = new System.Drawing.Point(709, 465);
            this.cash_Back.Name = "cash_Back";
            this.cash_Back.Size = new System.Drawing.Size(83, 37);
            this.cash_Back.TabIndex = 16;
            this.cash_Back.Text = "BACK";
            this.cash_Back.UseVisualStyleBackColor = true;
            this.cash_Back.Click += new System.EventHandler(this.cash_Back_Click);
            // 
            // Customer_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 514);
            this.Controls.Add(this.cash_Back);
            this.Controls.Add(this.btn_Customer_Add);
            this.Controls.Add(this.btn_Customer_edit);
            this.Controls.Add(this.btn_Customer_delete);
            this.Controls.Add(this.btn_Customer_Load);
            this.Controls.Add(this.btn_Customer_save);
            this.Controls.Add(this.grv_Customers);
            this.Name = "Customer_frm";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customer_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Customers;
        private Button btn_Customer_Add;
        private Button btn_Customer_edit;
        private Button btn_Customer_delete;
        private Button btn_Customer_Load;
        private Button btn_Customer_save;
        private Button cash_Back;
        private BindingSource bsCustomers;
        private DataGridViewTextBoxColumn col_ID;
        private DataGridViewTextBoxColumn col_Name;
        private DataGridViewTextBoxColumn col_Surname;
        private DataGridViewTextBoxColumn col_CardNum;
    }
}