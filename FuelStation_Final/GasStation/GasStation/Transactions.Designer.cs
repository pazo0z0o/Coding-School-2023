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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grv_Transactions = new System.Windows.Forms.DataGridView();
            this.grv_TransactionLine = new System.Windows.Forms.DataGridView();
            this.btn_Trans_save = new System.Windows.Forms.Button();
            this.btn_trans_Load = new System.Windows.Forms.Button();
            this.btn_trans_delete = new System.Windows.Forms.Button();
            this.btn_trl_delete = new System.Windows.Forms.Button();
            this.btn_trl_load = new System.Windows.Forms.Button();
            this.btn_trl_save = new System.Windows.Forms.Button();
            this.btn_trans_Add = new System.Windows.Forms.Button();
            this.btn_trl_Add = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.trans_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EmployeeID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_CustomerID = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Payment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_trl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_transID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransLine = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TransactionLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Transactions
            // 
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
            this.grv_Transactions.Size = new System.Drawing.Size(911, 175);
            this.grv_Transactions.TabIndex = 0;
            // 
            // grv_TransactionLine
            // 
            this.grv_TransactionLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_TransactionLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_TransactionLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_trl_ID,
            this.col_Quantity,
            this.col_ItemPrice,
            this.col_NetValue,
            this.col_DiscountPercent,
            this.col_DiscountValue,
            this.col_TotalValue,
            this.col_transID,
            this.col_ItemID});
            this.grv_TransactionLine.Location = new System.Drawing.Point(0, 449);
            this.grv_TransactionLine.Name = "grv_TransactionLine";
            this.grv_TransactionLine.RowTemplate.Height = 25;
            this.grv_TransactionLine.Size = new System.Drawing.Size(913, 180);
            this.grv_TransactionLine.TabIndex = 1;
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
            this.btn_trans_delete.Location = new System.Drawing.Point(975, 92);
            this.btn_trans_delete.Name = "btn_trans_delete";
            this.btn_trans_delete.Size = new System.Drawing.Size(49, 39);
            this.btn_trans_delete.TabIndex = 4;
            this.btn_trans_delete.Text = "DEL";
            this.btn_trans_delete.UseVisualStyleBackColor = false;
            // 
            // btn_trl_delete
            // 
            this.btn_trl_delete.BackColor = System.Drawing.Color.Red;
            this.btn_trl_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_delete.Location = new System.Drawing.Point(975, 539);
            this.btn_trl_delete.Name = "btn_trl_delete";
            this.btn_trl_delete.Size = new System.Drawing.Size(49, 39);
            this.btn_trl_delete.TabIndex = 8;
            this.btn_trl_delete.Text = "DEL";
            this.btn_trl_delete.UseVisualStyleBackColor = false;
            // 
            // btn_trl_load
            // 
            this.btn_trl_load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_trl_load.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_load.Location = new System.Drawing.Point(919, 494);
            this.btn_trl_load.Name = "btn_trl_load";
            this.btn_trl_load.Size = new System.Drawing.Size(105, 39);
            this.btn_trl_load.TabIndex = 7;
            this.btn_trl_load.Text = "Load";
            this.btn_trl_load.UseVisualStyleBackColor = false;
            // 
            // btn_trl_save
            // 
            this.btn_trl_save.BackColor = System.Drawing.Color.Gold;
            this.btn_trl_save.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_save.Location = new System.Drawing.Point(919, 449);
            this.btn_trl_save.Name = "btn_trl_save";
            this.btn_trl_save.Size = new System.Drawing.Size(105, 39);
            this.btn_trl_save.TabIndex = 6;
            this.btn_trl_save.Text = "Save";
            this.btn_trl_save.UseVisualStyleBackColor = false;
            // 
            // btn_trans_Add
            // 
            this.btn_trans_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_trans_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trans_Add.Location = new System.Drawing.Point(919, 92);
            this.btn_trans_Add.Name = "btn_trans_Add";
            this.btn_trans_Add.Size = new System.Drawing.Size(50, 39);
            this.btn_trans_Add.TabIndex = 10;
            this.btn_trans_Add.Text = "+Add";
            this.btn_trans_Add.UseVisualStyleBackColor = false;
            this.btn_trans_Add.Click += new System.EventHandler(this.btn_trans_Add_Click);
            // 
            // btn_trl_Add
            // 
            this.btn_trl_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_trl_Add.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_trl_Add.Location = new System.Drawing.Point(919, 539);
            this.btn_trl_Add.Name = "btn_trl_Add";
            this.btn_trl_Add.Size = new System.Drawing.Size(50, 39);
            this.btn_trl_Add.TabIndex = 11;
            this.btn_trl_Add.Text = "+Add";
            this.btn_trl_Add.UseVisualStyleBackColor = false;
            this.btn_trl_Add.Click += new System.EventHandler(this.btn_trl_Add_Click);
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
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(800, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "End Transaction";
            this.button1.UseVisualStyleBackColor = false;
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
            this.col_CustomerID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            dataGridViewCellStyle2.NullValue = null;
            this.col_Total.DefaultCellStyle = dataGridViewCellStyle2;
            this.col_Total.HeaderText = "Total Value";
            this.col_Total.Name = "col_Total";
            // 
            // col_trl_ID
            // 
            this.col_trl_ID.DataPropertyName = "ID";
            this.col_trl_ID.HeaderText = "TransactionLine ID";
            this.col_trl_ID.Name = "col_trl_ID";
            this.col_trl_ID.Visible = false;
            // 
            // col_Quantity
            // 
            this.col_Quantity.DataPropertyName = "Quantity";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.col_Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.Name = "col_Quantity";
            // 
            // col_ItemPrice
            // 
            this.col_ItemPrice.DataPropertyName = "ItemPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.col_ItemPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.col_ItemPrice.HeaderText = "Item Price";
            this.col_ItemPrice.Name = "col_ItemPrice";
            // 
            // col_NetValue
            // 
            this.col_NetValue.DataPropertyName = "NetValue";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "0";
            this.col_NetValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.col_NetValue.HeaderText = "Net Value";
            this.col_NetValue.Name = "col_NetValue";
            // 
            // col_DiscountPercent
            // 
            this.col_DiscountPercent.DataPropertyName = "DiscountPercentage";
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            this.col_DiscountPercent.DefaultCellStyle = dataGridViewCellStyle6;
            this.col_DiscountPercent.HeaderText = "Discount Percentage";
            this.col_DiscountPercent.Name = "col_DiscountPercent";
            // 
            // col_DiscountValue
            // 
            this.col_DiscountValue.DataPropertyName = "DiscountValue";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.col_DiscountValue.DefaultCellStyle = dataGridViewCellStyle7;
            this.col_DiscountValue.HeaderText = "Discount Value";
            this.col_DiscountValue.Name = "col_DiscountValue";
            // 
            // col_TotalValue
            // 
            this.col_TotalValue.DataPropertyName = "TotalValue";
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.col_TotalValue.DefaultCellStyle = dataGridViewCellStyle8;
            this.col_TotalValue.HeaderText = "Total Value";
            this.col_TotalValue.Name = "col_TotalValue";
            // 
            // col_transID
            // 
            this.col_transID.HeaderText = "TransactionID";
            this.col_transID.Name = "col_transID";
            this.col_transID.Visible = false;
            // 
            // col_ItemID
            // 
            this.col_ItemID.HeaderText = "Item ID";
            this.col_ItemID.Name = "col_ItemID";
            this.col_ItemID.Visible = false;
            // 
            // Transactions_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1028, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_trl_Add);
            this.Controls.Add(this.btn_trans_Add);
            this.Controls.Add(this.btn_trl_delete);
            this.Controls.Add(this.btn_trl_load);
            this.Controls.Add(this.btn_trl_save);
            this.Controls.Add(this.btn_trans_delete);
            this.Controls.Add(this.btn_trans_Load);
            this.Controls.Add(this.btn_Trans_save);
            this.Controls.Add(this.grv_TransactionLine);
            this.Controls.Add(this.grv_Transactions);
            this.Name = "Transactions_frm";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grv_Transactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TransactionLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Transactions;
        private DataGridView grv_TransactionLine;
        private Button btn_Trans_save;
        private Button btn_trans_Load;
        private Button btn_trans_delete;
        private Button btn_trl_delete;
        private Button btn_trl_load;
        private Button btn_trl_save;
        private Button btn_trans_Add;
        private Button btn_trl_Add;
        private Button btn_Back;
        private Button button1;
        private DataGridViewTextBoxColumn trans_ID;
        private DataGridViewTextBoxColumn col_Date;
        private DataGridViewComboBoxColumn col_EmployeeID;
        private DataGridViewComboBoxColumn col_CustomerID;
        private DataGridViewComboBoxColumn col_Payment;
        private DataGridViewTextBoxColumn col_Total;
        private DataGridViewTextBoxColumn col_trl_ID;
        private DataGridViewTextBoxColumn col_Quantity;
        private DataGridViewTextBoxColumn col_ItemPrice;
        private DataGridViewTextBoxColumn col_NetValue;
        private DataGridViewTextBoxColumn col_DiscountPercent;
        private DataGridViewTextBoxColumn col_DiscountValue;
        private DataGridViewTextBoxColumn col_TotalValue;
        private DataGridViewTextBoxColumn col_transID;
        private DataGridViewTextBoxColumn col_ItemID;
        private BindingSource bsTransLine;
        private BindingSource bsTransaction;
    }
}