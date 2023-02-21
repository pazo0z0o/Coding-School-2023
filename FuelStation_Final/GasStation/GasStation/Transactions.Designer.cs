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
            this.trans_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Payment = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.col_CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Transactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grv_TransactionLine)).BeginInit();
            this.SuspendLayout();
            // 
            // grv_Transactions
            // 
            this.grv_Transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Transactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trans_ID,
            this.col_Date,
            this.col_Total,
            this.col_Payment,
            this.col_CustomerID,
            this.col_EmployeeID});
            this.grv_Transactions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grv_Transactions.Location = new System.Drawing.Point(0, 0);
            this.grv_Transactions.Name = "grv_Transactions";
            this.grv_Transactions.RowTemplate.Height = 25;
            this.grv_Transactions.Size = new System.Drawing.Size(800, 110);
            this.grv_Transactions.TabIndex = 0;
            // 
            // grv_TransactionLine
            // 
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
            this.grv_TransactionLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grv_TransactionLine.Location = new System.Drawing.Point(0, 300);
            this.grv_TransactionLine.Name = "grv_TransactionLine";
            this.grv_TransactionLine.RowTemplate.Height = 25;
            this.grv_TransactionLine.Size = new System.Drawing.Size(800, 150);
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
            // Transactions_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grv_TransactionLine);
            this.Controls.Add(this.grv_Transactions);
            this.Name = "Transactions_frm";
            this.Text = "Transactions";
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
    }
}