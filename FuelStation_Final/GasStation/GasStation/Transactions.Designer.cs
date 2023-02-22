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
            this.grv_Transactions = new System.Windows.Forms.DataGridView();
            this.trans_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Payment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grv_TransactionLine = new System.Windows.Forms.DataGridView();
            this.col_trl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_transID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Trans_save = new System.Windows.Forms.Button();
            this.btn_trans_Load = new System.Windows.Forms.Button();
            this.btn_trans_delete = new System.Windows.Forms.Button();
            this.btn_trans_edit = new System.Windows.Forms.Button();
            this.btn_trl_del = new System.Windows.Forms.Button();
            this.btn_trl_delete = new System.Windows.Forms.Button();
            this.btn_trl_load = new System.Windows.Forms.Button();
            this.btn_trl_save = new System.Windows.Forms.Button();
            this.btn_trans_Add = new System.Windows.Forms.Button();
            this.btn_trl_Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Transactions
            // 
            this.grv_Transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grv_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_ID,
            this.col_Date,
            this.col_Total,
            this.col_Payment,
            this.col_CustomerID,
            this.col_EmployeeID});
            this.grv_Transactions.Location = new System.Drawing.Point(0, 0);
            this.grv_Transactions.Name = "grv_Transactions";
            this.grv_Transactions.RowTemplate.Height = 25;
            this.grv_Transactions.Size = new System.Drawing.Size(597, 96);
            this.grv_Transactions.TabIndex = 0;
            this.grv_Transactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_Transactions_CellContentClick);
            // 
            // trans_ID
            // 
            this.trans_ID.HeaderText = "Transaction ID";
            this.trans_ID.Name = "trans_ID";
            this.trans_ID.Visible = false;
            // 
            // col_Date
            // 
            this.col_Date.HeaderText = "Date";
            this.col_Date.Name = "col_Date";
            // 
            // col_Total
            // 
            this.col_Total.HeaderText = "Total Value";
            this.col_Total.Name = "col_Total";
            // 
            // col_Payment
            // 
            this.col_Payment.HeaderText = "Payment Method";
            this.col_Payment.Name = "col_Payment";
            this.col_Payment.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_Payment.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // col_CustomerID
            // 
            this.col_CustomerID.HeaderText = "CustomerID";
            this.col_CustomerID.Name = "col_CustomerID";
            this.col_CustomerID.Visible = false;
            // 
            // col_EmployeeID
            // 
            this.col_EmployeeID.HeaderText = "EmployeeID";
            this.col_EmployeeID.Name = "col_EmployeeID";
            this.col_EmployeeID.Visible = false;
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
            this.grv_TransactionLine.Size = new System.Drawing.Size(913, 150);
            this.grv_TransactionLine.TabIndex = 1;
            this.grv_TransactionLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_TransactionLine_CellContentClick);
            // 
            // col_trl_ID
            // 
            this.col_trl_ID.HeaderText = "TransactionLine ID";
            this.col_trl_ID.Name = "col_trl_ID";
            this.col_trl_ID.Visible = false;
            // 
            // col_Quantity
            // 
            this.col_Quantity.HeaderText = "Quantity";
            this.col_Quantity.Name = "col_Quantity";
            // 
            // col_ItemPrice
            // 
            this.col_ItemPrice.HeaderText = "Item Price";
            this.col_ItemPrice.Name = "col_ItemPrice";
            // 
            // col_NetValue
            // 
            this.col_NetValue.HeaderText = "Net Value";
            this.col_NetValue.Name = "col_NetValue";
            // 
            // col_DiscountPercent
            // 
            this.col_DiscountPercent.HeaderText = "Discount Percentage";
            this.col_DiscountPercent.Name = "col_DiscountPercent";
            // 
            // col_DiscountValue
            // 
            this.col_DiscountValue.HeaderText = "Discount Value";
            this.col_DiscountValue.Name = "col_DiscountValue";
            // 
            // col_TotalValue
            // 
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
            // btn_Trans_save
            // 
            this.btn_Trans_save.BackColor = System.Drawing.Color.Gold;
            this.btn_Trans_save.Location = new System.Drawing.Point(6, 116);
            this.btn_Trans_save.Name = "btn_Trans_save";
            this.btn_Trans_save.Size = new System.Drawing.Size(90, 39);
            this.btn_Trans_save.TabIndex = 2;
            this.btn_Trans_save.Text = "Save";
            this.btn_Trans_save.UseVisualStyleBackColor = false;
            // 
            // btn_trans_Load
            // 
            this.btn_trans_Load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_trans_Load.Location = new System.Drawing.Point(102, 116);
            this.btn_trans_Load.Name = "btn_trans_Load";
            this.btn_trans_Load.Size = new System.Drawing.Size(93, 39);
            this.btn_trans_Load.TabIndex = 3;
            this.btn_trans_Load.Text = "Load";
            this.btn_trans_Load.UseVisualStyleBackColor = false;
            // 
            // btn_trans_delete
            // 
            this.btn_trans_delete.BackColor = System.Drawing.Color.Red;
            this.btn_trans_delete.Location = new System.Drawing.Point(311, 116);
            this.btn_trans_delete.Name = "btn_trans_delete";
            this.btn_trans_delete.Size = new System.Drawing.Size(49, 39);
            this.btn_trans_delete.TabIndex = 4;
            this.btn_trans_delete.Text = "DEL";
            this.btn_trans_delete.UseVisualStyleBackColor = false;
            // 
            // btn_trans_edit
            // 
            this.btn_trans_edit.BackColor = System.Drawing.Color.Salmon;
            this.btn_trans_edit.Location = new System.Drawing.Point(201, 116);
            this.btn_trans_edit.Name = "btn_trans_edit";
            this.btn_trans_edit.Size = new System.Drawing.Size(48, 39);
            this.btn_trans_edit.TabIndex = 5;
            this.btn_trans_edit.Text = "Edit";
            this.btn_trans_edit.UseVisualStyleBackColor = false;
            // 
            // btn_trl_del
            // 
            this.btn_trl_del.BackColor = System.Drawing.Color.LightCoral;
            this.btn_trl_del.Location = new System.Drawing.Point(201, 404);
            this.btn_trl_del.Name = "btn_trl_del";
            this.btn_trl_del.Size = new System.Drawing.Size(48, 39);
            this.btn_trl_del.TabIndex = 9;
            this.btn_trl_del.Text = "Edit";
            this.btn_trl_del.UseVisualStyleBackColor = false;
            // 
            // btn_trl_delete
            // 
            this.btn_trl_delete.BackColor = System.Drawing.Color.Red;
            this.btn_trl_delete.Location = new System.Drawing.Point(311, 404);
            this.btn_trl_delete.Name = "btn_trl_delete";
            this.btn_trl_delete.Size = new System.Drawing.Size(49, 39);
            this.btn_trl_delete.TabIndex = 8;
            this.btn_trl_delete.Text = "DEL";
            this.btn_trl_delete.UseVisualStyleBackColor = false;
            // 
            // btn_trl_load
            // 
            this.btn_trl_load.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_trl_load.Location = new System.Drawing.Point(102, 404);
            this.btn_trl_load.Name = "btn_trl_load";
            this.btn_trl_load.Size = new System.Drawing.Size(93, 39);
            this.btn_trl_load.TabIndex = 7;
            this.btn_trl_load.Text = "Load";
            this.btn_trl_load.UseVisualStyleBackColor = false;
            // 
            // btn_trl_save
            // 
            this.btn_trl_save.BackColor = System.Drawing.Color.Gold;
            this.btn_trl_save.Location = new System.Drawing.Point(6, 404);
            this.btn_trl_save.Name = "btn_trl_save";
            this.btn_trl_save.Size = new System.Drawing.Size(90, 39);
            this.btn_trl_save.TabIndex = 6;
            this.btn_trl_save.Text = "Save";
            this.btn_trl_save.UseVisualStyleBackColor = false;
            // 
            // btn_trans_Add
            // 
            this.btn_trans_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_trans_Add.Location = new System.Drawing.Point(255, 116);
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
            this.btn_trl_Add.Location = new System.Drawing.Point(255, 404);
            this.btn_trl_Add.Name = "btn_trl_Add";
            this.btn_trl_Add.Size = new System.Drawing.Size(50, 39);
            this.btn_trl_Add.TabIndex = 11;
            this.btn_trl_Add.Text = "+Add";
            this.btn_trl_Add.UseVisualStyleBackColor = false;
            // 
            // Transactions_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1438, 599);
            this.Controls.Add(this.btn_trl_Add);
            this.Controls.Add(this.btn_trans_Add);
            this.Controls.Add(this.btn_trl_del);
            this.Controls.Add(this.btn_trl_delete);
            this.Controls.Add(this.btn_trl_load);
            this.Controls.Add(this.btn_trl_save);
            this.Controls.Add(this.btn_trans_edit);
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
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grv_Transactions;
        private DataGridView grv_TransactionLine;
        private DataGridViewTextBoxColumn trans_ID;
        private DataGridViewTextBoxColumn col_Date;
        private DataGridViewTextBoxColumn col_Total;
        private DataGridViewComboBoxColumn col_Payment;
        private DataGridViewTextBoxColumn col_CustomerID;
        private DataGridViewTextBoxColumn col_EmployeeID;
        private DataGridViewTextBoxColumn col_trl_ID;
        private DataGridViewTextBoxColumn col_Quantity;
        private DataGridViewTextBoxColumn col_ItemPrice;
        private DataGridViewTextBoxColumn col_NetValue;
        private DataGridViewTextBoxColumn col_DiscountPercent;
        private DataGridViewTextBoxColumn col_DiscountValue;
        private DataGridViewTextBoxColumn col_TotalValue;
        private DataGridViewTextBoxColumn col_transID;
        private DataGridViewTextBoxColumn col_ItemID;
        private Button btn_Trans_save;
        private Button btn_trans_Load;
        private Button btn_trans_delete;
        private Button btn_trans_edit;
        private Button btn_trl_del;
        private Button btn_trl_delete;
        private Button btn_trl_load;
        private Button btn_trl_save;
        private Button btn_trans_Add;
        private Button btn_trl_Add;
    }
}