namespace FuelStation.Win
{
    partial class Transactions_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grv_Transactions = new System.Windows.Forms.DataGridView();
            this.trans_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EmployeeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Payment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Trans_save = new System.Windows.Forms.Button();
            this.btn_trans_Load = new System.Windows.Forms.Button();
            this.btn_trans_delete = new System.Windows.Forms.Button();
            this.btn_trans_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.btn_customerCheck = new System.Windows.Forms.Button();
            this.btn_procceed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Transactions
            // 
            this.grv_Transactions.AllowUserToAddRows = false;
            this.grv_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_ID,
            this.col_Date,
            this.col_EmployeeID,
            this.col_CustomerID,
            this.col_Payment,
            this.col_Total});
            this.grv_Transactions.Location = new System.Drawing.Point(2, 2);
            this.grv_Transactions.Name = "grv_Transactions";
            this.grv_Transactions.RowTemplate.Height = 25;
            this.grv_Transactions.Size = new System.Drawing.Size(850, 175);
            this.grv_Transactions.TabIndex = 0;
            // 
            // trans_ID
            // 
            this.trans_ID.DataPropertyName = "ID";
            this.trans_ID.HeaderText = "Transaction ID";
            this.trans_ID.Name = "trans_ID";
            this.trans_ID.Visible = false;
            // 
            // col_Date
            // 
            this.col_Date.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.col_Date.DefaultCellStyle = dataGridViewCellStyle1;
            this.col_Date.HeaderText = "Date";
            this.col_Date.Name = "col_Date";
            // 
            // col_EmployeeID
            // 
            this.col_EmployeeID.HeaderText = "EmployeeID";
            this.col_EmployeeID.Name = "col_EmployeeID";
            this.col_EmployeeID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_EmployeeID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_CustomerID
            // 
            this.col_CustomerID.HeaderText = "CustomerID";
            this.col_CustomerID.Name = "col_CustomerID";
            this.col_CustomerID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_Payment
            // 
            this.col_Payment.DataPropertyName = "PaymentMethod";
            this.col_Payment.HeaderText = "Payment Method";
            this.col_Payment.Name = "col_Payment";
            this.col_Payment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Payment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_Total
            // 
            this.col_Total.DataPropertyName = "TotalValue";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            this.col_Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Total.HeaderText = "Total Value";
            this.col_Total.Name = "col_Total";
            // 
            // btn_Trans_save
            // 
            this.btn_Trans_save.BackColor = System.Drawing.Color.Gold;
            this.btn_Trans_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Trans_save.Location = new System.Drawing.Point(919, 2);
            this.btn_Trans_save.Name = "btn_Trans_save";
            this.btn_Trans_save.Size = new System.Drawing.Size(105, 39);
            this.btn_Trans_save.TabIndex = 2;
            this.btn_Trans_save.Text = "Save";
            this.btn_Trans_save.UseVisualStyleBackColor = false;
            // 
            // btn_trans_Load
            // 
            this.btn_trans_Load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_trans_Load.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trans_Load.Location = new System.Drawing.Point(919, 47);
            this.btn_trans_Load.Name = "btn_trans_Load";
            this.btn_trans_Load.Size = new System.Drawing.Size(105, 39);
            this.btn_trans_Load.TabIndex = 3;
            this.btn_trans_Load.Text = "Load";
            this.btn_trans_Load.UseVisualStyleBackColor = false;
            // 
            // btn_trans_delete
            // 
            this.btn_trans_delete.BackColor = System.Drawing.Color.Red;
            this.btn_trans_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trans_delete.Location = new System.Drawing.Point(920, 92);
            this.btn_trans_delete.Name = "btn_trans_delete";
            this.btn_trans_delete.Size = new System.Drawing.Size(104, 39);
            this.btn_trans_delete.TabIndex = 4;
            this.btn_trans_delete.Text = "DEL";
            this.btn_trans_delete.UseVisualStyleBackColor = false;
            // 
            // btn_trans_Add
            // 
            this.btn_trans_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_trans_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trans_Add.Location = new System.Drawing.Point(855, 227);
            this.btn_trans_Add.Name = "btn_trans_Add";
            this.btn_trans_Add.Size = new System.Drawing.Size(169, 39);
            this.btn_trans_Add.TabIndex = 10;
            this.btn_trans_Add.Text = "+Transaction";
            this.btn_trans_Add.UseVisualStyleBackColor = false;
            this.btn_trans_Add.Click += new System.EventHandler(this.btn_trans_Add_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Back.Location = new System.Drawing.Point(953, 604);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(71, 39);
            this.btn_Back.TabIndex = 30;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = false;
            // 
            // btn_customerCheck
            // 
            this.btn_customerCheck.BackColor = System.Drawing.Color.Gold;
            this.btn_customerCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_customerCheck.Location = new System.Drawing.Point(855, 182);
            this.btn_customerCheck.Name = "btn_customerCheck";
            this.btn_customerCheck.Size = new System.Drawing.Size(169, 39);
            this.btn_customerCheck.TabIndex = 31;
            this.btn_customerCheck.Text = "Check Customer Card";
            this.btn_customerCheck.UseVisualStyleBackColor = false;
            this.btn_customerCheck.Click += new System.EventHandler(this.btn_customerCheck_Click);
            // 
            // btn_procceed
            // 
            this.btn_procceed.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_procceed.Enabled = false;
            this.btn_procceed.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_procceed.Location = new System.Drawing.Point(855, 272);
            this.btn_procceed.Name = "btn_procceed";
            this.btn_procceed.Size = new System.Drawing.Size(169, 39);
            this.btn_procceed.TabIndex = 32;
            this.btn_procceed.Text = "Procceed to Order";
            this.btn_procceed.UseVisualStyleBackColor = false;
            this.btn_procceed.Click += new System.EventHandler(this.btn_procceed_Click);
            // 
            // Transactions_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 655);
            this.Controls.Add(this.btn_procceed);
            this.Controls.Add(this.btn_customerCheck);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_trans_Add);
            this.Controls.Add(this.btn_trans_delete);
            this.Controls.Add(this.btn_trans_Load);
            this.Controls.Add(this.btn_Trans_save);
            this.Controls.Add(this.grv_Transactions);
            this.Name = "Transactions_frm";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Transactions;
        private Button btn_Trans_save;
        private Button btn_trans_Load;
        private Button btn_trans_delete;
        private Button btn_trans_Add;
        private Button btn_Back;
        private BindingSource bsTransaction;
        private DataGridViewTextBoxColumn trans_ID;
        private DataGridViewTextBoxColumn col_Date;
        private DataGridViewComboBoxColumn col_EmployeeID;
        private DataGridViewTextBoxColumn col_CustomerID;
        private DataGridViewComboBoxColumn col_Payment;
        private DataGridViewTextBoxColumn col_Total;
        private Button btn_customerCheck;
        private Button btn_procceed;
    }
}