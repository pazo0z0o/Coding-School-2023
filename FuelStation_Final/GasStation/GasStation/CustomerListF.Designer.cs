namespace FuelStation.Win
{
    partial class CustomerListF
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
            this.cash_Back = new System.Windows.Forms.Button();
            this.btn_Customer_Add = new System.Windows.Forms.Button();
            this.btn_Customer_edit = new System.Windows.Forms.Button();
            this.btn_Customer_delete = new System.Windows.Forms.Button();
            this.btn_Customer_Load = new System.Windows.Forms.Button();
            this.btn_Customer_save = new System.Windows.Forms.Button();
            this.grv_Customers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // cash_Back
            // 
            this.cash_Back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cash_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cash_Back.Location = new System.Drawing.Point(717, 406);
            this.cash_Back.Name = "cash_Back";
            this.cash_Back.Size = new System.Drawing.Size(71, 39);
            this.cash_Back.TabIndex = 23;
            this.cash_Back.Text = "BACK";
            this.cash_Back.UseVisualStyleBackColor = false;
            this.cash_Back.Click += new System.EventHandler(this.cash_Back_Click);
            // 
            // btn_Customer_Add
            // 
            this.btn_Customer_Add.BackColor = System.Drawing.Color.Red;
            this.btn_Customer_Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Customer_Add.Location = new System.Drawing.Point(638, 406);
            this.btn_Customer_Add.Name = "btn_Customer_Add";
            this.btn_Customer_Add.Size = new System.Drawing.Size(73, 39);
            this.btn_Customer_Add.TabIndex = 22;
            this.btn_Customer_Add.Text = "X Close";
            this.btn_Customer_Add.UseVisualStyleBackColor = false;
            this.btn_Customer_Add.Click += new System.EventHandler(this.btn_Customer_Add_Click);
            // 
            // btn_Customer_edit
            // 
            this.btn_Customer_edit.BackColor = System.Drawing.Color.Salmon;
            this.btn_Customer_edit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Customer_edit.Location = new System.Drawing.Point(497, 147);
            this.btn_Customer_edit.Name = "btn_Customer_edit";
            this.btn_Customer_edit.Size = new System.Drawing.Size(117, 39);
            this.btn_Customer_edit.TabIndex = 21;
            this.btn_Customer_edit.Text = "Generate Card #";
            this.btn_Customer_edit.UseVisualStyleBackColor = false;
            this.btn_Customer_edit.Click += new System.EventHandler(this.btn_Customer_edit_Click);
            // 
            // btn_Customer_delete
            // 
            this.btn_Customer_delete.BackColor = System.Drawing.Color.Red;
            this.btn_Customer_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Customer_delete.Location = new System.Drawing.Point(639, 96);
            this.btn_Customer_delete.Name = "btn_Customer_delete";
            this.btn_Customer_delete.Size = new System.Drawing.Size(104, 39);
            this.btn_Customer_delete.TabIndex = 20;
            this.btn_Customer_delete.Text = "DEL";
            this.btn_Customer_delete.UseVisualStyleBackColor = false;
            this.btn_Customer_delete.Click += new System.EventHandler(this.btn_Customer_delete_Click);
            // 
            // btn_Customer_Load
            // 
            this.btn_Customer_Load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Customer_Load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Customer_Load.Location = new System.Drawing.Point(639, 51);
            this.btn_Customer_Load.Name = "btn_Customer_Load";
            this.btn_Customer_Load.Size = new System.Drawing.Size(104, 39);
            this.btn_Customer_Load.TabIndex = 19;
            this.btn_Customer_Load.Text = "Load";
            this.btn_Customer_Load.UseVisualStyleBackColor = false;
            this.btn_Customer_Load.Click += new System.EventHandler(this.btn_Customer_Load_Click);
            // 
            // btn_Customer_save
            // 
            this.btn_Customer_save.BackColor = System.Drawing.Color.Gold;
            this.btn_Customer_save.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Customer_save.Location = new System.Drawing.Point(639, 6);
            this.btn_Customer_save.Name = "btn_Customer_save";
            this.btn_Customer_save.Size = new System.Drawing.Size(104, 39);
            this.btn_Customer_save.TabIndex = 18;
            this.btn_Customer_save.Text = "Save";
            this.btn_Customer_save.UseVisualStyleBackColor = false;
            this.btn_Customer_save.Click += new System.EventHandler(this.btn_Customer_save_Click);
            // 
            // grv_Customers
            // 
            this.grv_Customers.AllowUserToDeleteRows = false;
            this.grv_Customers.AllowUserToResizeColumns = false;
            this.grv_Customers.AllowUserToResizeRows = false;
            this.grv_Customers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grv_Customers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.Surname,
            this.CardNumber});
            this.grv_Customers.Location = new System.Drawing.Point(10, 6);
            this.grv_Customers.Name = "grv_Customers";
            this.grv_Customers.RowTemplate.Height = 25;
            this.grv_Customers.Size = new System.Drawing.Size(604, 135);
            this.grv_Customers.TabIndex = 17;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // Surname
            // 
            this.Surname.DataPropertyName = "Surname";
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // CardNumber
            // 
            this.CardNumber.DataPropertyName = "CardNumber";
            this.CardNumber.HeaderText = "CardNumber";
            this.CardNumber.Name = "CardNumber";
            // 
            // CustomerListF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cash_Back);
            this.Controls.Add(this.btn_Customer_Add);
            this.Controls.Add(this.btn_Customer_edit);
            this.Controls.Add(this.btn_Customer_delete);
            this.Controls.Add(this.btn_Customer_Load);
            this.Controls.Add(this.btn_Customer_save);
            this.Controls.Add(this.grv_Customers);
            this.Name = "CustomerListF";
            this.Text = "CustomerListF";
            this.Load += new System.EventHandler(this.CustomerListF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button cash_Back;
        private Button btn_Customer_Add;
        private Button btn_Customer_edit;
        private Button btn_Customer_delete;
        private Button btn_Customer_Load;
        private Button btn_Customer_save;
        private DataGridView grv_Customers;
        private BindingSource bsCustomers;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn CardNumber;
    }
}